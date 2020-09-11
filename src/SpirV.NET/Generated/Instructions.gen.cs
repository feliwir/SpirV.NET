using System.IO;
namespace SpirVNET.Instructions
{
    public enum OpCode
    {
        OpNop = 0,
        OpUndef = 1,
        OpSourceContinued = 2,
        OpSource = 3,
        OpSourceExtension = 4,
        OpName = 5,
        OpMemberName = 6,
        OpString = 7,
        OpLine = 8,
        OpExtension = 10,
        OpExtInstImport = 11,
        OpExtInst = 12,
        OpMemoryModel = 14,
        OpEntryPoint = 15,
        OpExecutionMode = 16,
        OpCapability = 17,
        OpTypeVoid = 19,
        OpTypeBool = 20,
        OpTypeInt = 21,
        OpTypeFloat = 22,
        OpTypeVector = 23,
        OpTypeMatrix = 24,
        OpTypeImage = 25,
        OpTypeSampler = 26,
        OpTypeSampledImage = 27,
        OpTypeArray = 28,
        OpTypeRuntimeArray = 29,
        OpTypeStruct = 30,
        OpTypeOpaque = 31,
        OpTypePointer = 32,
        OpTypeFunction = 33,
        OpTypeEvent = 34,
        OpTypeDeviceEvent = 35,
        OpTypeReserveId = 36,
        OpTypeQueue = 37,
        OpTypePipe = 38,
        OpTypeForwardPointer = 39,
        OpConstantTrue = 41,
        OpConstantFalse = 42,
        OpConstant = 43,
        OpConstantComposite = 44,
        OpConstantSampler = 45,
        OpConstantNull = 46,
        OpSpecConstantTrue = 48,
        OpSpecConstantFalse = 49,
        OpSpecConstant = 50,
        OpSpecConstantComposite = 51,
        OpSpecConstantOp = 52,
        OpFunction = 54,
        OpFunctionParameter = 55,
        OpFunctionEnd = 56,
        OpFunctionCall = 57,
        OpVariable = 59,
        OpImageTexelPointer = 60,
        OpLoad = 61,
        OpStore = 62,
        OpCopyMemory = 63,
        OpCopyMemorySized = 64,
        OpAccessChain = 65,
        OpInBoundsAccessChain = 66,
        OpPtrAccessChain = 67,
        OpArrayLength = 68,
        OpGenericPtrMemSemantics = 69,
        OpInBoundsPtrAccessChain = 70,
        OpDecorate = 71,
        OpMemberDecorate = 72,
        OpDecorationGroup = 73,
        OpGroupDecorate = 74,
        OpGroupMemberDecorate = 75,
        OpVectorExtractDynamic = 77,
        OpVectorInsertDynamic = 78,
        OpVectorShuffle = 79,
        OpCompositeConstruct = 80,
        OpCompositeExtract = 81,
        OpCompositeInsert = 82,
        OpCopyObject = 83,
        OpTranspose = 84,
        OpSampledImage = 86,
        OpImageSampleImplicitLod = 87,
        OpImageSampleExplicitLod = 88,
        OpImageSampleDrefImplicitLod = 89,
        OpImageSampleDrefExplicitLod = 90,
        OpImageSampleProjImplicitLod = 91,
        OpImageSampleProjExplicitLod = 92,
        OpImageSampleProjDrefImplicitLod = 93,
        OpImageSampleProjDrefExplicitLod = 94,
        OpImageFetch = 95,
        OpImageGather = 96,
        OpImageDrefGather = 97,
        OpImageRead = 98,
        OpImageWrite = 99,
        OpImage = 100,
        OpImageQueryFormat = 101,
        OpImageQueryOrder = 102,
        OpImageQuerySizeLod = 103,
        OpImageQuerySize = 104,
        OpImageQueryLod = 105,
        OpImageQueryLevels = 106,
        OpImageQuerySamples = 107,
        OpConvertFToU = 109,
        OpConvertFToS = 110,
        OpConvertSToF = 111,
        OpConvertUToF = 112,
        OpUConvert = 113,
        OpSConvert = 114,
        OpFConvert = 115,
        OpQuantizeToF16 = 116,
        OpConvertPtrToU = 117,
        OpSatConvertSToU = 118,
        OpSatConvertUToS = 119,
        OpConvertUToPtr = 120,
        OpPtrCastToGeneric = 121,
        OpGenericCastToPtr = 122,
        OpGenericCastToPtrExplicit = 123,
        OpBitcast = 124,
        OpSNegate = 126,
        OpFNegate = 127,
        OpIAdd = 128,
        OpFAdd = 129,
        OpISub = 130,
        OpFSub = 131,
        OpIMul = 132,
        OpFMul = 133,
        OpUDiv = 134,
        OpSDiv = 135,
        OpFDiv = 136,
        OpUMod = 137,
        OpSRem = 138,
        OpSMod = 139,
        OpFRem = 140,
        OpFMod = 141,
        OpVectorTimesScalar = 142,
        OpMatrixTimesScalar = 143,
        OpVectorTimesMatrix = 144,
        OpMatrixTimesVector = 145,
        OpMatrixTimesMatrix = 146,
        OpOuterProduct = 147,
        OpDot = 148,
        OpIAddCarry = 149,
        OpISubBorrow = 150,
        OpUMulExtended = 151,
        OpSMulExtended = 152,
        OpAny = 154,
        OpAll = 155,
        OpIsNan = 156,
        OpIsInf = 157,
        OpIsFinite = 158,
        OpIsNormal = 159,
        OpSignBitSet = 160,
        OpLessOrGreater = 161,
        OpOrdered = 162,
        OpUnordered = 163,
        OpLogicalEqual = 164,
        OpLogicalNotEqual = 165,
        OpLogicalOr = 166,
        OpLogicalAnd = 167,
        OpLogicalNot = 168,
        OpSelect = 169,
        OpIEqual = 170,
        OpINotEqual = 171,
        OpUGreaterThan = 172,
        OpSGreaterThan = 173,
        OpUGreaterThanEqual = 174,
        OpSGreaterThanEqual = 175,
        OpULessThan = 176,
        OpSLessThan = 177,
        OpULessThanEqual = 178,
        OpSLessThanEqual = 179,
        OpFOrdEqual = 180,
        OpFUnordEqual = 181,
        OpFOrdNotEqual = 182,
        OpFUnordNotEqual = 183,
        OpFOrdLessThan = 184,
        OpFUnordLessThan = 185,
        OpFOrdGreaterThan = 186,
        OpFUnordGreaterThan = 187,
        OpFOrdLessThanEqual = 188,
        OpFUnordLessThanEqual = 189,
        OpFOrdGreaterThanEqual = 190,
        OpFUnordGreaterThanEqual = 191,
        OpShiftRightLogical = 194,
        OpShiftRightArithmetic = 195,
        OpShiftLeftLogical = 196,
        OpBitwiseOr = 197,
        OpBitwiseXor = 198,
        OpBitwiseAnd = 199,
        OpNot = 200,
        OpBitFieldInsert = 201,
        OpBitFieldSExtract = 202,
        OpBitFieldUExtract = 203,
        OpBitReverse = 204,
        OpBitCount = 205,
        OpDPdx = 207,
        OpDPdy = 208,
        OpFwidth = 209,
        OpDPdxFine = 210,
        OpDPdyFine = 211,
        OpFwidthFine = 212,
        OpDPdxCoarse = 213,
        OpDPdyCoarse = 214,
        OpFwidthCoarse = 215,
        OpEmitVertex = 218,
        OpEndPrimitive = 219,
        OpEmitStreamVertex = 220,
        OpEndStreamPrimitive = 221,
        OpControlBarrier = 224,
        OpMemoryBarrier = 225,
        OpAtomicLoad = 227,
        OpAtomicStore = 228,
        OpAtomicExchange = 229,
        OpAtomicCompareExchange = 230,
        OpAtomicCompareExchangeWeak = 231,
        OpAtomicIIncrement = 232,
        OpAtomicIDecrement = 233,
        OpAtomicIAdd = 234,
        OpAtomicISub = 235,
        OpAtomicSMin = 236,
        OpAtomicUMin = 237,
        OpAtomicSMax = 238,
        OpAtomicUMax = 239,
        OpAtomicAnd = 240,
        OpAtomicOr = 241,
        OpAtomicXor = 242,
        OpPhi = 245,
        OpLoopMerge = 246,
        OpSelectionMerge = 247,
        OpLabel = 248,
        OpBranch = 249,
        OpBranchConditional = 250,
        OpSwitch = 251,
        OpKill = 252,
        OpReturn = 253,
        OpReturnValue = 254,
        OpUnreachable = 255,
        OpLifetimeStart = 256,
        OpLifetimeStop = 257,
        OpGroupAsyncCopy = 259,
        OpGroupWaitEvents = 260,
        OpGroupAll = 261,
        OpGroupAny = 262,
        OpGroupBroadcast = 263,
        OpGroupIAdd = 264,
        OpGroupFAdd = 265,
        OpGroupFMin = 266,
        OpGroupUMin = 267,
        OpGroupSMin = 268,
        OpGroupFMax = 269,
        OpGroupUMax = 270,
        OpGroupSMax = 271,
        OpReadPipe = 274,
        OpWritePipe = 275,
        OpReservedReadPipe = 276,
        OpReservedWritePipe = 277,
        OpReserveReadPipePackets = 278,
        OpReserveWritePipePackets = 279,
        OpCommitReadPipe = 280,
        OpCommitWritePipe = 281,
        OpIsValidReserveId = 282,
        OpGetNumPipePackets = 283,
        OpGetMaxPipePackets = 284,
        OpGroupReserveReadPipePackets = 285,
        OpGroupReserveWritePipePackets = 286,
        OpGroupCommitReadPipe = 287,
        OpGroupCommitWritePipe = 288,
        OpEnqueueMarker = 291,
        OpEnqueueKernel = 292,
        OpGetKernelNDrangeSubGroupCount = 293,
        OpGetKernelNDrangeMaxSubGroupSize = 294,
        OpGetKernelWorkGroupSize = 295,
        OpGetKernelPreferredWorkGroupSizeMultiple = 296,
        OpRetainEvent = 297,
        OpReleaseEvent = 298,
        OpCreateUserEvent = 299,
        OpIsValidEvent = 300,
        OpSetUserEventStatus = 301,
        OpCaptureEventProfilingInfo = 302,
        OpGetDefaultQueue = 303,
        OpBuildNDRange = 304,
        OpImageSparseSampleImplicitLod = 305,
        OpImageSparseSampleExplicitLod = 306,
        OpImageSparseSampleDrefImplicitLod = 307,
        OpImageSparseSampleDrefExplicitLod = 308,
        OpImageSparseSampleProjImplicitLod = 309,
        OpImageSparseSampleProjExplicitLod = 310,
        OpImageSparseSampleProjDrefImplicitLod = 311,
        OpImageSparseSampleProjDrefExplicitLod = 312,
        OpImageSparseFetch = 313,
        OpImageSparseGather = 314,
        OpImageSparseDrefGather = 315,
        OpImageSparseTexelsResident = 316,
        OpNoLine = 317,
        OpAtomicFlagTestAndSet = 318,
        OpAtomicFlagClear = 319,
        OpImageSparseRead = 320,
        OpSizeOf = 321,
        OpTypePipeStorage = 322,
        OpConstantPipeStorage = 323,
        OpCreatePipeFromPipeStorage = 324,
        OpGetKernelLocalSizeForSubgroupCount = 325,
        OpGetKernelMaxNumSubgroups = 326,
        OpTypeNamedBarrier = 327,
        OpNamedBarrierInitialize = 328,
        OpMemoryNamedBarrier = 329,
        OpModuleProcessed = 330,
        OpExecutionModeId = 331,
        OpDecorateId = 332,
        OpGroupNonUniformElect = 333,
        OpGroupNonUniformAll = 334,
        OpGroupNonUniformAny = 335,
        OpGroupNonUniformAllEqual = 336,
        OpGroupNonUniformBroadcast = 337,
        OpGroupNonUniformBroadcastFirst = 338,
        OpGroupNonUniformBallot = 339,
        OpGroupNonUniformInverseBallot = 340,
        OpGroupNonUniformBallotBitExtract = 341,
        OpGroupNonUniformBallotBitCount = 342,
        OpGroupNonUniformBallotFindLSB = 343,
        OpGroupNonUniformBallotFindMSB = 344,
        OpGroupNonUniformShuffle = 345,
        OpGroupNonUniformShuffleXor = 346,
        OpGroupNonUniformShuffleUp = 347,
        OpGroupNonUniformShuffleDown = 348,
        OpGroupNonUniformIAdd = 349,
        OpGroupNonUniformFAdd = 350,
        OpGroupNonUniformIMul = 351,
        OpGroupNonUniformFMul = 352,
        OpGroupNonUniformSMin = 353,
        OpGroupNonUniformUMin = 354,
        OpGroupNonUniformFMin = 355,
        OpGroupNonUniformSMax = 356,
        OpGroupNonUniformUMax = 357,
        OpGroupNonUniformFMax = 358,
        OpGroupNonUniformBitwiseAnd = 359,
        OpGroupNonUniformBitwiseOr = 360,
        OpGroupNonUniformBitwiseXor = 361,
        OpGroupNonUniformLogicalAnd = 362,
        OpGroupNonUniformLogicalOr = 363,
        OpGroupNonUniformLogicalXor = 364,
        OpGroupNonUniformQuadBroadcast = 365,
        OpGroupNonUniformQuadSwap = 366,
        OpCopyLogical = 400,
        OpPtrEqual = 401,
        OpPtrNotEqual = 402,
        OpPtrDiff = 403,
        OpTerminateInvocation = 4416,
        OpSubgroupBallotKHR = 4421,
        OpSubgroupFirstInvocationKHR = 4422,
        OpSubgroupAllKHR = 4428,
        OpSubgroupAnyKHR = 4429,
        OpSubgroupAllEqualKHR = 4430,
        OpSubgroupReadInvocationKHR = 4432,
        OpTypeRayQueryProvisionalKHR = 4472,
        OpRayQueryInitializeKHR = 4473,
        OpRayQueryTerminateKHR = 4474,
        OpRayQueryGenerateIntersectionKHR = 4475,
        OpRayQueryConfirmIntersectionKHR = 4476,
        OpRayQueryProceedKHR = 4477,
        OpRayQueryGetIntersectionTypeKHR = 4479,
        OpGroupIAddNonUniformAMD = 5000,
        OpGroupFAddNonUniformAMD = 5001,
        OpGroupFMinNonUniformAMD = 5002,
        OpGroupUMinNonUniformAMD = 5003,
        OpGroupSMinNonUniformAMD = 5004,
        OpGroupFMaxNonUniformAMD = 5005,
        OpGroupUMaxNonUniformAMD = 5006,
        OpGroupSMaxNonUniformAMD = 5007,
        OpFragmentMaskFetchAMD = 5011,
        OpFragmentFetchAMD = 5012,
        OpReadClockKHR = 5056,
        OpImageSampleFootprintNV = 5283,
        OpGroupNonUniformPartitionNV = 5296,
        OpWritePackedPrimitiveIndices4x8NV = 5299,
        OpReportIntersectionNV = 5334,
        OpReportIntersectionKHR = 5334,
        OpIgnoreIntersectionNV = 5335,
        OpIgnoreIntersectionKHR = 5335,
        OpTerminateRayNV = 5336,
        OpTerminateRayKHR = 5336,
        OpTraceNV = 5337,
        OpTraceRayKHR = 5337,
        OpTypeAccelerationStructureNV = 5341,
        OpTypeAccelerationStructureKHR = 5341,
        OpExecuteCallableNV = 5344,
        OpExecuteCallableKHR = 5344,
        OpTypeCooperativeMatrixNV = 5358,
        OpCooperativeMatrixLoadNV = 5359,
        OpCooperativeMatrixStoreNV = 5360,
        OpCooperativeMatrixMulAddNV = 5361,
        OpCooperativeMatrixLengthNV = 5362,
        OpBeginInvocationInterlockEXT = 5364,
        OpEndInvocationInterlockEXT = 5365,
        OpDemoteToHelperInvocationEXT = 5380,
        OpIsHelperInvocationEXT = 5381,
        OpSubgroupShuffleINTEL = 5571,
        OpSubgroupShuffleDownINTEL = 5572,
        OpSubgroupShuffleUpINTEL = 5573,
        OpSubgroupShuffleXorINTEL = 5574,
        OpSubgroupBlockReadINTEL = 5575,
        OpSubgroupBlockWriteINTEL = 5576,
        OpSubgroupImageBlockReadINTEL = 5577,
        OpSubgroupImageBlockWriteINTEL = 5578,
        OpSubgroupImageMediaBlockReadINTEL = 5580,
        OpSubgroupImageMediaBlockWriteINTEL = 5581,
        OpUCountLeadingZerosINTEL = 5585,
        OpUCountTrailingZerosINTEL = 5586,
        OpAbsISubINTEL = 5587,
        OpAbsUSubINTEL = 5588,
        OpIAddSatINTEL = 5589,
        OpUAddSatINTEL = 5590,
        OpIAverageINTEL = 5591,
        OpUAverageINTEL = 5592,
        OpIAverageRoundedINTEL = 5593,
        OpUAverageRoundedINTEL = 5594,
        OpISubSatINTEL = 5595,
        OpUSubSatINTEL = 5596,
        OpIMul32x16INTEL = 5597,
        OpUMul32x16INTEL = 5598,
        OpFunctionPointerINTEL = 5600,
        OpFunctionPointerCallINTEL = 5601,
        OpDecorateString = 5632,
        OpDecorateStringGOOGLE = 5632,
        OpMemberDecorateString = 5633,
        OpMemberDecorateStringGOOGLE = 5633,
        OpVmeImageINTEL = 5699,
        OpTypeVmeImageINTEL = 5700,
        OpTypeAvcImePayloadINTEL = 5701,
        OpTypeAvcRefPayloadINTEL = 5702,
        OpTypeAvcSicPayloadINTEL = 5703,
        OpTypeAvcMcePayloadINTEL = 5704,
        OpTypeAvcMceResultINTEL = 5705,
        OpTypeAvcImeResultINTEL = 5706,
        OpTypeAvcImeResultSingleReferenceStreamoutINTEL = 5707,
        OpTypeAvcImeResultDualReferenceStreamoutINTEL = 5708,
        OpTypeAvcImeSingleReferenceStreaminINTEL = 5709,
        OpTypeAvcImeDualReferenceStreaminINTEL = 5710,
        OpTypeAvcRefResultINTEL = 5711,
        OpTypeAvcSicResultINTEL = 5712,
        OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL = 5713,
        OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL = 5714,
        OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL = 5715,
        OpSubgroupAvcMceSetInterShapePenaltyINTEL = 5716,
        OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL = 5717,
        OpSubgroupAvcMceSetInterDirectionPenaltyINTEL = 5718,
        OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL = 5719,
        OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL = 5720,
        OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL = 5721,
        OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL = 5722,
        OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL = 5723,
        OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL = 5724,
        OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL = 5725,
        OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL = 5726,
        OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL = 5727,
        OpSubgroupAvcMceSetAcOnlyHaarINTEL = 5728,
        OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL = 5729,
        OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL = 5730,
        OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL = 5731,
        OpSubgroupAvcMceConvertToImePayloadINTEL = 5732,
        OpSubgroupAvcMceConvertToImeResultINTEL = 5733,
        OpSubgroupAvcMceConvertToRefPayloadINTEL = 5734,
        OpSubgroupAvcMceConvertToRefResultINTEL = 5735,
        OpSubgroupAvcMceConvertToSicPayloadINTEL = 5736,
        OpSubgroupAvcMceConvertToSicResultINTEL = 5737,
        OpSubgroupAvcMceGetMotionVectorsINTEL = 5738,
        OpSubgroupAvcMceGetInterDistortionsINTEL = 5739,
        OpSubgroupAvcMceGetBestInterDistortionsINTEL = 5740,
        OpSubgroupAvcMceGetInterMajorShapeINTEL = 5741,
        OpSubgroupAvcMceGetInterMinorShapeINTEL = 5742,
        OpSubgroupAvcMceGetInterDirectionsINTEL = 5743,
        OpSubgroupAvcMceGetInterMotionVectorCountINTEL = 5744,
        OpSubgroupAvcMceGetInterReferenceIdsINTEL = 5745,
        OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL = 5746,
        OpSubgroupAvcImeInitializeINTEL = 5747,
        OpSubgroupAvcImeSetSingleReferenceINTEL = 5748,
        OpSubgroupAvcImeSetDualReferenceINTEL = 5749,
        OpSubgroupAvcImeRefWindowSizeINTEL = 5750,
        OpSubgroupAvcImeAdjustRefOffsetINTEL = 5751,
        OpSubgroupAvcImeConvertToMcePayloadINTEL = 5752,
        OpSubgroupAvcImeSetMaxMotionVectorCountINTEL = 5753,
        OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL = 5754,
        OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL = 5755,
        OpSubgroupAvcImeSetWeightedSadINTEL = 5756,
        OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL = 5757,
        OpSubgroupAvcImeEvaluateWithDualReferenceINTEL = 5758,
        OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL = 5759,
        OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL = 5760,
        OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL = 5761,
        OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL = 5762,
        OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL = 5763,
        OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL = 5764,
        OpSubgroupAvcImeConvertToMceResultINTEL = 5765,
        OpSubgroupAvcImeGetSingleReferenceStreaminINTEL = 5766,
        OpSubgroupAvcImeGetDualReferenceStreaminINTEL = 5767,
        OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL = 5768,
        OpSubgroupAvcImeStripDualReferenceStreamoutINTEL = 5769,
        OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL = 5770,
        OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL = 5771,
        OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL = 5772,
        OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL = 5773,
        OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL = 5774,
        OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL = 5775,
        OpSubgroupAvcImeGetBorderReachedINTEL = 5776,
        OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL = 5777,
        OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL = 5778,
        OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL = 5779,
        OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL = 5780,
        OpSubgroupAvcFmeInitializeINTEL = 5781,
        OpSubgroupAvcBmeInitializeINTEL = 5782,
        OpSubgroupAvcRefConvertToMcePayloadINTEL = 5783,
        OpSubgroupAvcRefSetBidirectionalMixDisableINTEL = 5784,
        OpSubgroupAvcRefSetBilinearFilterEnableINTEL = 5785,
        OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL = 5786,
        OpSubgroupAvcRefEvaluateWithDualReferenceINTEL = 5787,
        OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL = 5788,
        OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL = 5789,
        OpSubgroupAvcRefConvertToMceResultINTEL = 5790,
        OpSubgroupAvcSicInitializeINTEL = 5791,
        OpSubgroupAvcSicConfigureSkcINTEL = 5792,
        OpSubgroupAvcSicConfigureIpeLumaINTEL = 5793,
        OpSubgroupAvcSicConfigureIpeLumaChromaINTEL = 5794,
        OpSubgroupAvcSicGetMotionVectorMaskINTEL = 5795,
        OpSubgroupAvcSicConvertToMcePayloadINTEL = 5796,
        OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL = 5797,
        OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL = 5798,
        OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL = 5799,
        OpSubgroupAvcSicSetBilinearFilterEnableINTEL = 5800,
        OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL = 5801,
        OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL = 5802,
        OpSubgroupAvcSicEvaluateIpeINTEL = 5803,
        OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL = 5804,
        OpSubgroupAvcSicEvaluateWithDualReferenceINTEL = 5805,
        OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL = 5806,
        OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL = 5807,
        OpSubgroupAvcSicConvertToMceResultINTEL = 5808,
        OpSubgroupAvcSicGetIpeLumaShapeINTEL = 5809,
        OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL = 5810,
        OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL = 5811,
        OpSubgroupAvcSicGetPackedIpeLumaModesINTEL = 5812,
        OpSubgroupAvcSicGetIpeChromaModeINTEL = 5813,
        OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL = 5814,
        OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL = 5815,
        OpSubgroupAvcSicGetInterRawSadsINTEL = 5816,
        OpLoopControlINTEL = 5887,
        OpReadPipeBlockingINTEL = 5946,
        OpWritePipeBlockingINTEL = 5947,
        OpFPGARegINTEL = 5949,
        OpRayQueryGetRayTMinKHR = 6016,
        OpRayQueryGetRayFlagsKHR = 6017,
        OpRayQueryGetIntersectionTKHR = 6018,
        OpRayQueryGetIntersectionInstanceCustomIndexKHR = 6019,
        OpRayQueryGetIntersectionInstanceIdKHR = 6020,
        OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR = 6021,
        OpRayQueryGetIntersectionGeometryIndexKHR = 6022,
        OpRayQueryGetIntersectionPrimitiveIndexKHR = 6023,
        OpRayQueryGetIntersectionBarycentricsKHR = 6024,
        OpRayQueryGetIntersectionFrontFaceKHR = 6025,
        OpRayQueryGetIntersectionCandidateAABBOpaqueKHR = 6026,
        OpRayQueryGetIntersectionObjectRayDirectionKHR = 6027,
        OpRayQueryGetIntersectionObjectRayOriginKHR = 6028,
        OpRayQueryGetWorldRayDirectionKHR = 6029,
        OpRayQueryGetWorldRayOriginKHR = 6030,
        OpRayQueryGetIntersectionObjectToWorldKHR = 6031,
        OpRayQueryGetIntersectionWorldToObjectKHR = 6032,
        OpAtomicFAddEXT = 6035,
    }
    public static class InstructionCreator
    {
        public static IInstruction CreateInstruction(OpCode opcode)
        {
            switch(opcode)
            {
                case OpCode.OpNop: return new OpNop();
                case OpCode.OpUndef: return new OpUndef();
                case OpCode.OpSourceContinued: return new OpSourceContinued();
                case OpCode.OpSource: return new OpSource();
                case OpCode.OpSourceExtension: return new OpSourceExtension();
                case OpCode.OpName: return new OpName();
                case OpCode.OpMemberName: return new OpMemberName();
                case OpCode.OpString: return new OpString();
                case OpCode.OpLine: return new OpLine();
                case OpCode.OpExtension: return new OpExtension();
                case OpCode.OpExtInstImport: return new OpExtInstImport();
                case OpCode.OpExtInst: return new OpExtInst();
                case OpCode.OpMemoryModel: return new OpMemoryModel();
                case OpCode.OpEntryPoint: return new OpEntryPoint();
                case OpCode.OpExecutionMode: return new OpExecutionMode();
                case OpCode.OpCapability: return new OpCapability();
                case OpCode.OpTypeVoid: return new OpTypeVoid();
                case OpCode.OpTypeBool: return new OpTypeBool();
                case OpCode.OpTypeInt: return new OpTypeInt();
                case OpCode.OpTypeFloat: return new OpTypeFloat();
                case OpCode.OpTypeVector: return new OpTypeVector();
                case OpCode.OpTypeMatrix: return new OpTypeMatrix();
                case OpCode.OpTypeImage: return new OpTypeImage();
                case OpCode.OpTypeSampler: return new OpTypeSampler();
                case OpCode.OpTypeSampledImage: return new OpTypeSampledImage();
                case OpCode.OpTypeArray: return new OpTypeArray();
                case OpCode.OpTypeRuntimeArray: return new OpTypeRuntimeArray();
                case OpCode.OpTypeStruct: return new OpTypeStruct();
                case OpCode.OpTypeOpaque: return new OpTypeOpaque();
                case OpCode.OpTypePointer: return new OpTypePointer();
                case OpCode.OpTypeFunction: return new OpTypeFunction();
                case OpCode.OpTypeEvent: return new OpTypeEvent();
                case OpCode.OpTypeDeviceEvent: return new OpTypeDeviceEvent();
                case OpCode.OpTypeReserveId: return new OpTypeReserveId();
                case OpCode.OpTypeQueue: return new OpTypeQueue();
                case OpCode.OpTypePipe: return new OpTypePipe();
                case OpCode.OpTypeForwardPointer: return new OpTypeForwardPointer();
                case OpCode.OpConstantTrue: return new OpConstantTrue();
                case OpCode.OpConstantFalse: return new OpConstantFalse();
                case OpCode.OpConstant: return new OpConstant();
                case OpCode.OpConstantComposite: return new OpConstantComposite();
                case OpCode.OpConstantSampler: return new OpConstantSampler();
                case OpCode.OpConstantNull: return new OpConstantNull();
                case OpCode.OpSpecConstantTrue: return new OpSpecConstantTrue();
                case OpCode.OpSpecConstantFalse: return new OpSpecConstantFalse();
                case OpCode.OpSpecConstant: return new OpSpecConstant();
                case OpCode.OpSpecConstantComposite: return new OpSpecConstantComposite();
                case OpCode.OpSpecConstantOp: return new OpSpecConstantOp();
                case OpCode.OpFunction: return new OpFunction();
                case OpCode.OpFunctionParameter: return new OpFunctionParameter();
                case OpCode.OpFunctionEnd: return new OpFunctionEnd();
                case OpCode.OpFunctionCall: return new OpFunctionCall();
                case OpCode.OpVariable: return new OpVariable();
                case OpCode.OpImageTexelPointer: return new OpImageTexelPointer();
                case OpCode.OpLoad: return new OpLoad();
                case OpCode.OpStore: return new OpStore();
                case OpCode.OpCopyMemory: return new OpCopyMemory();
                case OpCode.OpCopyMemorySized: return new OpCopyMemorySized();
                case OpCode.OpAccessChain: return new OpAccessChain();
                case OpCode.OpInBoundsAccessChain: return new OpInBoundsAccessChain();
                case OpCode.OpPtrAccessChain: return new OpPtrAccessChain();
                case OpCode.OpArrayLength: return new OpArrayLength();
                case OpCode.OpGenericPtrMemSemantics: return new OpGenericPtrMemSemantics();
                case OpCode.OpInBoundsPtrAccessChain: return new OpInBoundsPtrAccessChain();
                case OpCode.OpDecorate: return new OpDecorate();
                case OpCode.OpMemberDecorate: return new OpMemberDecorate();
                case OpCode.OpDecorationGroup: return new OpDecorationGroup();
                case OpCode.OpGroupDecorate: return new OpGroupDecorate();
                case OpCode.OpGroupMemberDecorate: return new OpGroupMemberDecorate();
                case OpCode.OpVectorExtractDynamic: return new OpVectorExtractDynamic();
                case OpCode.OpVectorInsertDynamic: return new OpVectorInsertDynamic();
                case OpCode.OpVectorShuffle: return new OpVectorShuffle();
                case OpCode.OpCompositeConstruct: return new OpCompositeConstruct();
                case OpCode.OpCompositeExtract: return new OpCompositeExtract();
                case OpCode.OpCompositeInsert: return new OpCompositeInsert();
                case OpCode.OpCopyObject: return new OpCopyObject();
                case OpCode.OpTranspose: return new OpTranspose();
                case OpCode.OpSampledImage: return new OpSampledImage();
                case OpCode.OpImageSampleImplicitLod: return new OpImageSampleImplicitLod();
                case OpCode.OpImageSampleExplicitLod: return new OpImageSampleExplicitLod();
                case OpCode.OpImageSampleDrefImplicitLod: return new OpImageSampleDrefImplicitLod();
                case OpCode.OpImageSampleDrefExplicitLod: return new OpImageSampleDrefExplicitLod();
                case OpCode.OpImageSampleProjImplicitLod: return new OpImageSampleProjImplicitLod();
                case OpCode.OpImageSampleProjExplicitLod: return new OpImageSampleProjExplicitLod();
                case OpCode.OpImageSampleProjDrefImplicitLod: return new OpImageSampleProjDrefImplicitLod();
                case OpCode.OpImageSampleProjDrefExplicitLod: return new OpImageSampleProjDrefExplicitLod();
                case OpCode.OpImageFetch: return new OpImageFetch();
                case OpCode.OpImageGather: return new OpImageGather();
                case OpCode.OpImageDrefGather: return new OpImageDrefGather();
                case OpCode.OpImageRead: return new OpImageRead();
                case OpCode.OpImageWrite: return new OpImageWrite();
                case OpCode.OpImage: return new OpImage();
                case OpCode.OpImageQueryFormat: return new OpImageQueryFormat();
                case OpCode.OpImageQueryOrder: return new OpImageQueryOrder();
                case OpCode.OpImageQuerySizeLod: return new OpImageQuerySizeLod();
                case OpCode.OpImageQuerySize: return new OpImageQuerySize();
                case OpCode.OpImageQueryLod: return new OpImageQueryLod();
                case OpCode.OpImageQueryLevels: return new OpImageQueryLevels();
                case OpCode.OpImageQuerySamples: return new OpImageQuerySamples();
                case OpCode.OpConvertFToU: return new OpConvertFToU();
                case OpCode.OpConvertFToS: return new OpConvertFToS();
                case OpCode.OpConvertSToF: return new OpConvertSToF();
                case OpCode.OpConvertUToF: return new OpConvertUToF();
                case OpCode.OpUConvert: return new OpUConvert();
                case OpCode.OpSConvert: return new OpSConvert();
                case OpCode.OpFConvert: return new OpFConvert();
                case OpCode.OpQuantizeToF16: return new OpQuantizeToF16();
                case OpCode.OpConvertPtrToU: return new OpConvertPtrToU();
                case OpCode.OpSatConvertSToU: return new OpSatConvertSToU();
                case OpCode.OpSatConvertUToS: return new OpSatConvertUToS();
                case OpCode.OpConvertUToPtr: return new OpConvertUToPtr();
                case OpCode.OpPtrCastToGeneric: return new OpPtrCastToGeneric();
                case OpCode.OpGenericCastToPtr: return new OpGenericCastToPtr();
                case OpCode.OpGenericCastToPtrExplicit: return new OpGenericCastToPtrExplicit();
                case OpCode.OpBitcast: return new OpBitcast();
                case OpCode.OpSNegate: return new OpSNegate();
                case OpCode.OpFNegate: return new OpFNegate();
                case OpCode.OpIAdd: return new OpIAdd();
                case OpCode.OpFAdd: return new OpFAdd();
                case OpCode.OpISub: return new OpISub();
                case OpCode.OpFSub: return new OpFSub();
                case OpCode.OpIMul: return new OpIMul();
                case OpCode.OpFMul: return new OpFMul();
                case OpCode.OpUDiv: return new OpUDiv();
                case OpCode.OpSDiv: return new OpSDiv();
                case OpCode.OpFDiv: return new OpFDiv();
                case OpCode.OpUMod: return new OpUMod();
                case OpCode.OpSRem: return new OpSRem();
                case OpCode.OpSMod: return new OpSMod();
                case OpCode.OpFRem: return new OpFRem();
                case OpCode.OpFMod: return new OpFMod();
                case OpCode.OpVectorTimesScalar: return new OpVectorTimesScalar();
                case OpCode.OpMatrixTimesScalar: return new OpMatrixTimesScalar();
                case OpCode.OpVectorTimesMatrix: return new OpVectorTimesMatrix();
                case OpCode.OpMatrixTimesVector: return new OpMatrixTimesVector();
                case OpCode.OpMatrixTimesMatrix: return new OpMatrixTimesMatrix();
                case OpCode.OpOuterProduct: return new OpOuterProduct();
                case OpCode.OpDot: return new OpDot();
                case OpCode.OpIAddCarry: return new OpIAddCarry();
                case OpCode.OpISubBorrow: return new OpISubBorrow();
                case OpCode.OpUMulExtended: return new OpUMulExtended();
                case OpCode.OpSMulExtended: return new OpSMulExtended();
                case OpCode.OpAny: return new OpAny();
                case OpCode.OpAll: return new OpAll();
                case OpCode.OpIsNan: return new OpIsNan();
                case OpCode.OpIsInf: return new OpIsInf();
                case OpCode.OpIsFinite: return new OpIsFinite();
                case OpCode.OpIsNormal: return new OpIsNormal();
                case OpCode.OpSignBitSet: return new OpSignBitSet();
                case OpCode.OpLessOrGreater: return new OpLessOrGreater();
                case OpCode.OpOrdered: return new OpOrdered();
                case OpCode.OpUnordered: return new OpUnordered();
                case OpCode.OpLogicalEqual: return new OpLogicalEqual();
                case OpCode.OpLogicalNotEqual: return new OpLogicalNotEqual();
                case OpCode.OpLogicalOr: return new OpLogicalOr();
                case OpCode.OpLogicalAnd: return new OpLogicalAnd();
                case OpCode.OpLogicalNot: return new OpLogicalNot();
                case OpCode.OpSelect: return new OpSelect();
                case OpCode.OpIEqual: return new OpIEqual();
                case OpCode.OpINotEqual: return new OpINotEqual();
                case OpCode.OpUGreaterThan: return new OpUGreaterThan();
                case OpCode.OpSGreaterThan: return new OpSGreaterThan();
                case OpCode.OpUGreaterThanEqual: return new OpUGreaterThanEqual();
                case OpCode.OpSGreaterThanEqual: return new OpSGreaterThanEqual();
                case OpCode.OpULessThan: return new OpULessThan();
                case OpCode.OpSLessThan: return new OpSLessThan();
                case OpCode.OpULessThanEqual: return new OpULessThanEqual();
                case OpCode.OpSLessThanEqual: return new OpSLessThanEqual();
                case OpCode.OpFOrdEqual: return new OpFOrdEqual();
                case OpCode.OpFUnordEqual: return new OpFUnordEqual();
                case OpCode.OpFOrdNotEqual: return new OpFOrdNotEqual();
                case OpCode.OpFUnordNotEqual: return new OpFUnordNotEqual();
                case OpCode.OpFOrdLessThan: return new OpFOrdLessThan();
                case OpCode.OpFUnordLessThan: return new OpFUnordLessThan();
                case OpCode.OpFOrdGreaterThan: return new OpFOrdGreaterThan();
                case OpCode.OpFUnordGreaterThan: return new OpFUnordGreaterThan();
                case OpCode.OpFOrdLessThanEqual: return new OpFOrdLessThanEqual();
                case OpCode.OpFUnordLessThanEqual: return new OpFUnordLessThanEqual();
                case OpCode.OpFOrdGreaterThanEqual: return new OpFOrdGreaterThanEqual();
                case OpCode.OpFUnordGreaterThanEqual: return new OpFUnordGreaterThanEqual();
                case OpCode.OpShiftRightLogical: return new OpShiftRightLogical();
                case OpCode.OpShiftRightArithmetic: return new OpShiftRightArithmetic();
                case OpCode.OpShiftLeftLogical: return new OpShiftLeftLogical();
                case OpCode.OpBitwiseOr: return new OpBitwiseOr();
                case OpCode.OpBitwiseXor: return new OpBitwiseXor();
                case OpCode.OpBitwiseAnd: return new OpBitwiseAnd();
                case OpCode.OpNot: return new OpNot();
                case OpCode.OpBitFieldInsert: return new OpBitFieldInsert();
                case OpCode.OpBitFieldSExtract: return new OpBitFieldSExtract();
                case OpCode.OpBitFieldUExtract: return new OpBitFieldUExtract();
                case OpCode.OpBitReverse: return new OpBitReverse();
                case OpCode.OpBitCount: return new OpBitCount();
                case OpCode.OpDPdx: return new OpDPdx();
                case OpCode.OpDPdy: return new OpDPdy();
                case OpCode.OpFwidth: return new OpFwidth();
                case OpCode.OpDPdxFine: return new OpDPdxFine();
                case OpCode.OpDPdyFine: return new OpDPdyFine();
                case OpCode.OpFwidthFine: return new OpFwidthFine();
                case OpCode.OpDPdxCoarse: return new OpDPdxCoarse();
                case OpCode.OpDPdyCoarse: return new OpDPdyCoarse();
                case OpCode.OpFwidthCoarse: return new OpFwidthCoarse();
                case OpCode.OpEmitVertex: return new OpEmitVertex();
                case OpCode.OpEndPrimitive: return new OpEndPrimitive();
                case OpCode.OpEmitStreamVertex: return new OpEmitStreamVertex();
                case OpCode.OpEndStreamPrimitive: return new OpEndStreamPrimitive();
                case OpCode.OpControlBarrier: return new OpControlBarrier();
                case OpCode.OpMemoryBarrier: return new OpMemoryBarrier();
                case OpCode.OpAtomicLoad: return new OpAtomicLoad();
                case OpCode.OpAtomicStore: return new OpAtomicStore();
                case OpCode.OpAtomicExchange: return new OpAtomicExchange();
                case OpCode.OpAtomicCompareExchange: return new OpAtomicCompareExchange();
                case OpCode.OpAtomicCompareExchangeWeak: return new OpAtomicCompareExchangeWeak();
                case OpCode.OpAtomicIIncrement: return new OpAtomicIIncrement();
                case OpCode.OpAtomicIDecrement: return new OpAtomicIDecrement();
                case OpCode.OpAtomicIAdd: return new OpAtomicIAdd();
                case OpCode.OpAtomicISub: return new OpAtomicISub();
                case OpCode.OpAtomicSMin: return new OpAtomicSMin();
                case OpCode.OpAtomicUMin: return new OpAtomicUMin();
                case OpCode.OpAtomicSMax: return new OpAtomicSMax();
                case OpCode.OpAtomicUMax: return new OpAtomicUMax();
                case OpCode.OpAtomicAnd: return new OpAtomicAnd();
                case OpCode.OpAtomicOr: return new OpAtomicOr();
                case OpCode.OpAtomicXor: return new OpAtomicXor();
                case OpCode.OpPhi: return new OpPhi();
                case OpCode.OpLoopMerge: return new OpLoopMerge();
                case OpCode.OpSelectionMerge: return new OpSelectionMerge();
                case OpCode.OpLabel: return new OpLabel();
                case OpCode.OpBranch: return new OpBranch();
                case OpCode.OpBranchConditional: return new OpBranchConditional();
                case OpCode.OpSwitch: return new OpSwitch();
                case OpCode.OpKill: return new OpKill();
                case OpCode.OpReturn: return new OpReturn();
                case OpCode.OpReturnValue: return new OpReturnValue();
                case OpCode.OpUnreachable: return new OpUnreachable();
                case OpCode.OpLifetimeStart: return new OpLifetimeStart();
                case OpCode.OpLifetimeStop: return new OpLifetimeStop();
                case OpCode.OpGroupAsyncCopy: return new OpGroupAsyncCopy();
                case OpCode.OpGroupWaitEvents: return new OpGroupWaitEvents();
                case OpCode.OpGroupAll: return new OpGroupAll();
                case OpCode.OpGroupAny: return new OpGroupAny();
                case OpCode.OpGroupBroadcast: return new OpGroupBroadcast();
                case OpCode.OpGroupIAdd: return new OpGroupIAdd();
                case OpCode.OpGroupFAdd: return new OpGroupFAdd();
                case OpCode.OpGroupFMin: return new OpGroupFMin();
                case OpCode.OpGroupUMin: return new OpGroupUMin();
                case OpCode.OpGroupSMin: return new OpGroupSMin();
                case OpCode.OpGroupFMax: return new OpGroupFMax();
                case OpCode.OpGroupUMax: return new OpGroupUMax();
                case OpCode.OpGroupSMax: return new OpGroupSMax();
                case OpCode.OpReadPipe: return new OpReadPipe();
                case OpCode.OpWritePipe: return new OpWritePipe();
                case OpCode.OpReservedReadPipe: return new OpReservedReadPipe();
                case OpCode.OpReservedWritePipe: return new OpReservedWritePipe();
                case OpCode.OpReserveReadPipePackets: return new OpReserveReadPipePackets();
                case OpCode.OpReserveWritePipePackets: return new OpReserveWritePipePackets();
                case OpCode.OpCommitReadPipe: return new OpCommitReadPipe();
                case OpCode.OpCommitWritePipe: return new OpCommitWritePipe();
                case OpCode.OpIsValidReserveId: return new OpIsValidReserveId();
                case OpCode.OpGetNumPipePackets: return new OpGetNumPipePackets();
                case OpCode.OpGetMaxPipePackets: return new OpGetMaxPipePackets();
                case OpCode.OpGroupReserveReadPipePackets: return new OpGroupReserveReadPipePackets();
                case OpCode.OpGroupReserveWritePipePackets: return new OpGroupReserveWritePipePackets();
                case OpCode.OpGroupCommitReadPipe: return new OpGroupCommitReadPipe();
                case OpCode.OpGroupCommitWritePipe: return new OpGroupCommitWritePipe();
                case OpCode.OpEnqueueMarker: return new OpEnqueueMarker();
                case OpCode.OpEnqueueKernel: return new OpEnqueueKernel();
                case OpCode.OpGetKernelNDrangeSubGroupCount: return new OpGetKernelNDrangeSubGroupCount();
                case OpCode.OpGetKernelNDrangeMaxSubGroupSize: return new OpGetKernelNDrangeMaxSubGroupSize();
                case OpCode.OpGetKernelWorkGroupSize: return new OpGetKernelWorkGroupSize();
                case OpCode.OpGetKernelPreferredWorkGroupSizeMultiple: return new OpGetKernelPreferredWorkGroupSizeMultiple();
                case OpCode.OpRetainEvent: return new OpRetainEvent();
                case OpCode.OpReleaseEvent: return new OpReleaseEvent();
                case OpCode.OpCreateUserEvent: return new OpCreateUserEvent();
                case OpCode.OpIsValidEvent: return new OpIsValidEvent();
                case OpCode.OpSetUserEventStatus: return new OpSetUserEventStatus();
                case OpCode.OpCaptureEventProfilingInfo: return new OpCaptureEventProfilingInfo();
                case OpCode.OpGetDefaultQueue: return new OpGetDefaultQueue();
                case OpCode.OpBuildNDRange: return new OpBuildNDRange();
                case OpCode.OpImageSparseSampleImplicitLod: return new OpImageSparseSampleImplicitLod();
                case OpCode.OpImageSparseSampleExplicitLod: return new OpImageSparseSampleExplicitLod();
                case OpCode.OpImageSparseSampleDrefImplicitLod: return new OpImageSparseSampleDrefImplicitLod();
                case OpCode.OpImageSparseSampleDrefExplicitLod: return new OpImageSparseSampleDrefExplicitLod();
                case OpCode.OpImageSparseSampleProjImplicitLod: return new OpImageSparseSampleProjImplicitLod();
                case OpCode.OpImageSparseSampleProjExplicitLod: return new OpImageSparseSampleProjExplicitLod();
                case OpCode.OpImageSparseSampleProjDrefImplicitLod: return new OpImageSparseSampleProjDrefImplicitLod();
                case OpCode.OpImageSparseSampleProjDrefExplicitLod: return new OpImageSparseSampleProjDrefExplicitLod();
                case OpCode.OpImageSparseFetch: return new OpImageSparseFetch();
                case OpCode.OpImageSparseGather: return new OpImageSparseGather();
                case OpCode.OpImageSparseDrefGather: return new OpImageSparseDrefGather();
                case OpCode.OpImageSparseTexelsResident: return new OpImageSparseTexelsResident();
                case OpCode.OpNoLine: return new OpNoLine();
                case OpCode.OpAtomicFlagTestAndSet: return new OpAtomicFlagTestAndSet();
                case OpCode.OpAtomicFlagClear: return new OpAtomicFlagClear();
                case OpCode.OpImageSparseRead: return new OpImageSparseRead();
                case OpCode.OpSizeOf: return new OpSizeOf();
                case OpCode.OpTypePipeStorage: return new OpTypePipeStorage();
                case OpCode.OpConstantPipeStorage: return new OpConstantPipeStorage();
                case OpCode.OpCreatePipeFromPipeStorage: return new OpCreatePipeFromPipeStorage();
                case OpCode.OpGetKernelLocalSizeForSubgroupCount: return new OpGetKernelLocalSizeForSubgroupCount();
                case OpCode.OpGetKernelMaxNumSubgroups: return new OpGetKernelMaxNumSubgroups();
                case OpCode.OpTypeNamedBarrier: return new OpTypeNamedBarrier();
                case OpCode.OpNamedBarrierInitialize: return new OpNamedBarrierInitialize();
                case OpCode.OpMemoryNamedBarrier: return new OpMemoryNamedBarrier();
                case OpCode.OpModuleProcessed: return new OpModuleProcessed();
                case OpCode.OpExecutionModeId: return new OpExecutionModeId();
                case OpCode.OpDecorateId: return new OpDecorateId();
                case OpCode.OpGroupNonUniformElect: return new OpGroupNonUniformElect();
                case OpCode.OpGroupNonUniformAll: return new OpGroupNonUniformAll();
                case OpCode.OpGroupNonUniformAny: return new OpGroupNonUniformAny();
                case OpCode.OpGroupNonUniformAllEqual: return new OpGroupNonUniformAllEqual();
                case OpCode.OpGroupNonUniformBroadcast: return new OpGroupNonUniformBroadcast();
                case OpCode.OpGroupNonUniformBroadcastFirst: return new OpGroupNonUniformBroadcastFirst();
                case OpCode.OpGroupNonUniformBallot: return new OpGroupNonUniformBallot();
                case OpCode.OpGroupNonUniformInverseBallot: return new OpGroupNonUniformInverseBallot();
                case OpCode.OpGroupNonUniformBallotBitExtract: return new OpGroupNonUniformBallotBitExtract();
                case OpCode.OpGroupNonUniformBallotBitCount: return new OpGroupNonUniformBallotBitCount();
                case OpCode.OpGroupNonUniformBallotFindLSB: return new OpGroupNonUniformBallotFindLSB();
                case OpCode.OpGroupNonUniformBallotFindMSB: return new OpGroupNonUniformBallotFindMSB();
                case OpCode.OpGroupNonUniformShuffle: return new OpGroupNonUniformShuffle();
                case OpCode.OpGroupNonUniformShuffleXor: return new OpGroupNonUniformShuffleXor();
                case OpCode.OpGroupNonUniformShuffleUp: return new OpGroupNonUniformShuffleUp();
                case OpCode.OpGroupNonUniformShuffleDown: return new OpGroupNonUniformShuffleDown();
                case OpCode.OpGroupNonUniformIAdd: return new OpGroupNonUniformIAdd();
                case OpCode.OpGroupNonUniformFAdd: return new OpGroupNonUniformFAdd();
                case OpCode.OpGroupNonUniformIMul: return new OpGroupNonUniformIMul();
                case OpCode.OpGroupNonUniformFMul: return new OpGroupNonUniformFMul();
                case OpCode.OpGroupNonUniformSMin: return new OpGroupNonUniformSMin();
                case OpCode.OpGroupNonUniformUMin: return new OpGroupNonUniformUMin();
                case OpCode.OpGroupNonUniformFMin: return new OpGroupNonUniformFMin();
                case OpCode.OpGroupNonUniformSMax: return new OpGroupNonUniformSMax();
                case OpCode.OpGroupNonUniformUMax: return new OpGroupNonUniformUMax();
                case OpCode.OpGroupNonUniformFMax: return new OpGroupNonUniformFMax();
                case OpCode.OpGroupNonUniformBitwiseAnd: return new OpGroupNonUniformBitwiseAnd();
                case OpCode.OpGroupNonUniformBitwiseOr: return new OpGroupNonUniformBitwiseOr();
                case OpCode.OpGroupNonUniformBitwiseXor: return new OpGroupNonUniformBitwiseXor();
                case OpCode.OpGroupNonUniformLogicalAnd: return new OpGroupNonUniformLogicalAnd();
                case OpCode.OpGroupNonUniformLogicalOr: return new OpGroupNonUniformLogicalOr();
                case OpCode.OpGroupNonUniformLogicalXor: return new OpGroupNonUniformLogicalXor();
                case OpCode.OpGroupNonUniformQuadBroadcast: return new OpGroupNonUniformQuadBroadcast();
                case OpCode.OpGroupNonUniformQuadSwap: return new OpGroupNonUniformQuadSwap();
                case OpCode.OpCopyLogical: return new OpCopyLogical();
                case OpCode.OpPtrEqual: return new OpPtrEqual();
                case OpCode.OpPtrNotEqual: return new OpPtrNotEqual();
                case OpCode.OpPtrDiff: return new OpPtrDiff();
                case OpCode.OpTerminateInvocation: return new OpTerminateInvocation();
                case OpCode.OpSubgroupBallotKHR: return new OpSubgroupBallotKHR();
                case OpCode.OpSubgroupFirstInvocationKHR: return new OpSubgroupFirstInvocationKHR();
                case OpCode.OpSubgroupAllKHR: return new OpSubgroupAllKHR();
                case OpCode.OpSubgroupAnyKHR: return new OpSubgroupAnyKHR();
                case OpCode.OpSubgroupAllEqualKHR: return new OpSubgroupAllEqualKHR();
                case OpCode.OpSubgroupReadInvocationKHR: return new OpSubgroupReadInvocationKHR();
                case OpCode.OpTypeRayQueryProvisionalKHR: return new OpTypeRayQueryProvisionalKHR();
                case OpCode.OpRayQueryInitializeKHR: return new OpRayQueryInitializeKHR();
                case OpCode.OpRayQueryTerminateKHR: return new OpRayQueryTerminateKHR();
                case OpCode.OpRayQueryGenerateIntersectionKHR: return new OpRayQueryGenerateIntersectionKHR();
                case OpCode.OpRayQueryConfirmIntersectionKHR: return new OpRayQueryConfirmIntersectionKHR();
                case OpCode.OpRayQueryProceedKHR: return new OpRayQueryProceedKHR();
                case OpCode.OpRayQueryGetIntersectionTypeKHR: return new OpRayQueryGetIntersectionTypeKHR();
                case OpCode.OpGroupIAddNonUniformAMD: return new OpGroupIAddNonUniformAMD();
                case OpCode.OpGroupFAddNonUniformAMD: return new OpGroupFAddNonUniformAMD();
                case OpCode.OpGroupFMinNonUniformAMD: return new OpGroupFMinNonUniformAMD();
                case OpCode.OpGroupUMinNonUniformAMD: return new OpGroupUMinNonUniformAMD();
                case OpCode.OpGroupSMinNonUniformAMD: return new OpGroupSMinNonUniformAMD();
                case OpCode.OpGroupFMaxNonUniformAMD: return new OpGroupFMaxNonUniformAMD();
                case OpCode.OpGroupUMaxNonUniformAMD: return new OpGroupUMaxNonUniformAMD();
                case OpCode.OpGroupSMaxNonUniformAMD: return new OpGroupSMaxNonUniformAMD();
                case OpCode.OpFragmentMaskFetchAMD: return new OpFragmentMaskFetchAMD();
                case OpCode.OpFragmentFetchAMD: return new OpFragmentFetchAMD();
                case OpCode.OpReadClockKHR: return new OpReadClockKHR();
                case OpCode.OpImageSampleFootprintNV: return new OpImageSampleFootprintNV();
                case OpCode.OpGroupNonUniformPartitionNV: return new OpGroupNonUniformPartitionNV();
                case OpCode.OpWritePackedPrimitiveIndices4x8NV: return new OpWritePackedPrimitiveIndices4x8NV();
                case OpCode.OpReportIntersectionNV: return new OpReportIntersectionNV();
                case OpCode.OpIgnoreIntersectionNV: return new OpIgnoreIntersectionNV();
                case OpCode.OpTerminateRayNV: return new OpTerminateRayNV();
                case OpCode.OpTraceNV: return new OpTraceNV();
                case OpCode.OpTypeAccelerationStructureNV: return new OpTypeAccelerationStructureNV();
                case OpCode.OpExecuteCallableNV: return new OpExecuteCallableNV();
                case OpCode.OpTypeCooperativeMatrixNV: return new OpTypeCooperativeMatrixNV();
                case OpCode.OpCooperativeMatrixLoadNV: return new OpCooperativeMatrixLoadNV();
                case OpCode.OpCooperativeMatrixStoreNV: return new OpCooperativeMatrixStoreNV();
                case OpCode.OpCooperativeMatrixMulAddNV: return new OpCooperativeMatrixMulAddNV();
                case OpCode.OpCooperativeMatrixLengthNV: return new OpCooperativeMatrixLengthNV();
                case OpCode.OpBeginInvocationInterlockEXT: return new OpBeginInvocationInterlockEXT();
                case OpCode.OpEndInvocationInterlockEXT: return new OpEndInvocationInterlockEXT();
                case OpCode.OpDemoteToHelperInvocationEXT: return new OpDemoteToHelperInvocationEXT();
                case OpCode.OpIsHelperInvocationEXT: return new OpIsHelperInvocationEXT();
                case OpCode.OpSubgroupShuffleINTEL: return new OpSubgroupShuffleINTEL();
                case OpCode.OpSubgroupShuffleDownINTEL: return new OpSubgroupShuffleDownINTEL();
                case OpCode.OpSubgroupShuffleUpINTEL: return new OpSubgroupShuffleUpINTEL();
                case OpCode.OpSubgroupShuffleXorINTEL: return new OpSubgroupShuffleXorINTEL();
                case OpCode.OpSubgroupBlockReadINTEL: return new OpSubgroupBlockReadINTEL();
                case OpCode.OpSubgroupBlockWriteINTEL: return new OpSubgroupBlockWriteINTEL();
                case OpCode.OpSubgroupImageBlockReadINTEL: return new OpSubgroupImageBlockReadINTEL();
                case OpCode.OpSubgroupImageBlockWriteINTEL: return new OpSubgroupImageBlockWriteINTEL();
                case OpCode.OpSubgroupImageMediaBlockReadINTEL: return new OpSubgroupImageMediaBlockReadINTEL();
                case OpCode.OpSubgroupImageMediaBlockWriteINTEL: return new OpSubgroupImageMediaBlockWriteINTEL();
                case OpCode.OpUCountLeadingZerosINTEL: return new OpUCountLeadingZerosINTEL();
                case OpCode.OpUCountTrailingZerosINTEL: return new OpUCountTrailingZerosINTEL();
                case OpCode.OpAbsISubINTEL: return new OpAbsISubINTEL();
                case OpCode.OpAbsUSubINTEL: return new OpAbsUSubINTEL();
                case OpCode.OpIAddSatINTEL: return new OpIAddSatINTEL();
                case OpCode.OpUAddSatINTEL: return new OpUAddSatINTEL();
                case OpCode.OpIAverageINTEL: return new OpIAverageINTEL();
                case OpCode.OpUAverageINTEL: return new OpUAverageINTEL();
                case OpCode.OpIAverageRoundedINTEL: return new OpIAverageRoundedINTEL();
                case OpCode.OpUAverageRoundedINTEL: return new OpUAverageRoundedINTEL();
                case OpCode.OpISubSatINTEL: return new OpISubSatINTEL();
                case OpCode.OpUSubSatINTEL: return new OpUSubSatINTEL();
                case OpCode.OpIMul32x16INTEL: return new OpIMul32x16INTEL();
                case OpCode.OpUMul32x16INTEL: return new OpUMul32x16INTEL();
                case OpCode.OpFunctionPointerINTEL: return new OpFunctionPointerINTEL();
                case OpCode.OpFunctionPointerCallINTEL: return new OpFunctionPointerCallINTEL();
                case OpCode.OpDecorateString: return new OpDecorateString();
                case OpCode.OpMemberDecorateString: return new OpMemberDecorateString();
                case OpCode.OpVmeImageINTEL: return new OpVmeImageINTEL();
                case OpCode.OpTypeVmeImageINTEL: return new OpTypeVmeImageINTEL();
                case OpCode.OpTypeAvcImePayloadINTEL: return new OpTypeAvcImePayloadINTEL();
                case OpCode.OpTypeAvcRefPayloadINTEL: return new OpTypeAvcRefPayloadINTEL();
                case OpCode.OpTypeAvcSicPayloadINTEL: return new OpTypeAvcSicPayloadINTEL();
                case OpCode.OpTypeAvcMcePayloadINTEL: return new OpTypeAvcMcePayloadINTEL();
                case OpCode.OpTypeAvcMceResultINTEL: return new OpTypeAvcMceResultINTEL();
                case OpCode.OpTypeAvcImeResultINTEL: return new OpTypeAvcImeResultINTEL();
                case OpCode.OpTypeAvcImeResultSingleReferenceStreamoutINTEL: return new OpTypeAvcImeResultSingleReferenceStreamoutINTEL();
                case OpCode.OpTypeAvcImeResultDualReferenceStreamoutINTEL: return new OpTypeAvcImeResultDualReferenceStreamoutINTEL();
                case OpCode.OpTypeAvcImeSingleReferenceStreaminINTEL: return new OpTypeAvcImeSingleReferenceStreaminINTEL();
                case OpCode.OpTypeAvcImeDualReferenceStreaminINTEL: return new OpTypeAvcImeDualReferenceStreaminINTEL();
                case OpCode.OpTypeAvcRefResultINTEL: return new OpTypeAvcRefResultINTEL();
                case OpCode.OpTypeAvcSicResultINTEL: return new OpTypeAvcSicResultINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL: return new OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL();
                case OpCode.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL: return new OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL: return new OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL();
                case OpCode.OpSubgroupAvcMceSetInterShapePenaltyINTEL: return new OpSubgroupAvcMceSetInterShapePenaltyINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL: return new OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL();
                case OpCode.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL: return new OpSubgroupAvcMceSetInterDirectionPenaltyINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL: return new OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL: return new OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL: return new OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL: return new OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL: return new OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL();
                case OpCode.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL: return new OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL: return new OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL: return new OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL();
                case OpCode.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL: return new OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL();
                case OpCode.OpSubgroupAvcMceSetAcOnlyHaarINTEL: return new OpSubgroupAvcMceSetAcOnlyHaarINTEL();
                case OpCode.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL: return new OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL();
                case OpCode.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL: return new OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL();
                case OpCode.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL: return new OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL();
                case OpCode.OpSubgroupAvcMceConvertToImePayloadINTEL: return new OpSubgroupAvcMceConvertToImePayloadINTEL();
                case OpCode.OpSubgroupAvcMceConvertToImeResultINTEL: return new OpSubgroupAvcMceConvertToImeResultINTEL();
                case OpCode.OpSubgroupAvcMceConvertToRefPayloadINTEL: return new OpSubgroupAvcMceConvertToRefPayloadINTEL();
                case OpCode.OpSubgroupAvcMceConvertToRefResultINTEL: return new OpSubgroupAvcMceConvertToRefResultINTEL();
                case OpCode.OpSubgroupAvcMceConvertToSicPayloadINTEL: return new OpSubgroupAvcMceConvertToSicPayloadINTEL();
                case OpCode.OpSubgroupAvcMceConvertToSicResultINTEL: return new OpSubgroupAvcMceConvertToSicResultINTEL();
                case OpCode.OpSubgroupAvcMceGetMotionVectorsINTEL: return new OpSubgroupAvcMceGetMotionVectorsINTEL();
                case OpCode.OpSubgroupAvcMceGetInterDistortionsINTEL: return new OpSubgroupAvcMceGetInterDistortionsINTEL();
                case OpCode.OpSubgroupAvcMceGetBestInterDistortionsINTEL: return new OpSubgroupAvcMceGetBestInterDistortionsINTEL();
                case OpCode.OpSubgroupAvcMceGetInterMajorShapeINTEL: return new OpSubgroupAvcMceGetInterMajorShapeINTEL();
                case OpCode.OpSubgroupAvcMceGetInterMinorShapeINTEL: return new OpSubgroupAvcMceGetInterMinorShapeINTEL();
                case OpCode.OpSubgroupAvcMceGetInterDirectionsINTEL: return new OpSubgroupAvcMceGetInterDirectionsINTEL();
                case OpCode.OpSubgroupAvcMceGetInterMotionVectorCountINTEL: return new OpSubgroupAvcMceGetInterMotionVectorCountINTEL();
                case OpCode.OpSubgroupAvcMceGetInterReferenceIdsINTEL: return new OpSubgroupAvcMceGetInterReferenceIdsINTEL();
                case OpCode.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL: return new OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL();
                case OpCode.OpSubgroupAvcImeInitializeINTEL: return new OpSubgroupAvcImeInitializeINTEL();
                case OpCode.OpSubgroupAvcImeSetSingleReferenceINTEL: return new OpSubgroupAvcImeSetSingleReferenceINTEL();
                case OpCode.OpSubgroupAvcImeSetDualReferenceINTEL: return new OpSubgroupAvcImeSetDualReferenceINTEL();
                case OpCode.OpSubgroupAvcImeRefWindowSizeINTEL: return new OpSubgroupAvcImeRefWindowSizeINTEL();
                case OpCode.OpSubgroupAvcImeAdjustRefOffsetINTEL: return new OpSubgroupAvcImeAdjustRefOffsetINTEL();
                case OpCode.OpSubgroupAvcImeConvertToMcePayloadINTEL: return new OpSubgroupAvcImeConvertToMcePayloadINTEL();
                case OpCode.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL: return new OpSubgroupAvcImeSetMaxMotionVectorCountINTEL();
                case OpCode.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL: return new OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL();
                case OpCode.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL: return new OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL();
                case OpCode.OpSubgroupAvcImeSetWeightedSadINTEL: return new OpSubgroupAvcImeSetWeightedSadINTEL();
                case OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL: return new OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL();
                case OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL: return new OpSubgroupAvcImeEvaluateWithDualReferenceINTEL();
                case OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL: return new OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL();
                case OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL: return new OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL();
                case OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL: return new OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL();
                case OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL: return new OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL();
                case OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL: return new OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL();
                case OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL: return new OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL();
                case OpCode.OpSubgroupAvcImeConvertToMceResultINTEL: return new OpSubgroupAvcImeConvertToMceResultINTEL();
                case OpCode.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL: return new OpSubgroupAvcImeGetSingleReferenceStreaminINTEL();
                case OpCode.OpSubgroupAvcImeGetDualReferenceStreaminINTEL: return new OpSubgroupAvcImeGetDualReferenceStreaminINTEL();
                case OpCode.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL: return new OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL();
                case OpCode.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL: return new OpSubgroupAvcImeStripDualReferenceStreamoutINTEL();
                case OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL: return new OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL();
                case OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL: return new OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL();
                case OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL: return new OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL();
                case OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL: return new OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL();
                case OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL: return new OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL();
                case OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL: return new OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL();
                case OpCode.OpSubgroupAvcImeGetBorderReachedINTEL: return new OpSubgroupAvcImeGetBorderReachedINTEL();
                case OpCode.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL: return new OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL();
                case OpCode.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL: return new OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL();
                case OpCode.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL: return new OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL();
                case OpCode.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL: return new OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL();
                case OpCode.OpSubgroupAvcFmeInitializeINTEL: return new OpSubgroupAvcFmeInitializeINTEL();
                case OpCode.OpSubgroupAvcBmeInitializeINTEL: return new OpSubgroupAvcBmeInitializeINTEL();
                case OpCode.OpSubgroupAvcRefConvertToMcePayloadINTEL: return new OpSubgroupAvcRefConvertToMcePayloadINTEL();
                case OpCode.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL: return new OpSubgroupAvcRefSetBidirectionalMixDisableINTEL();
                case OpCode.OpSubgroupAvcRefSetBilinearFilterEnableINTEL: return new OpSubgroupAvcRefSetBilinearFilterEnableINTEL();
                case OpCode.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL: return new OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL();
                case OpCode.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL: return new OpSubgroupAvcRefEvaluateWithDualReferenceINTEL();
                case OpCode.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL: return new OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL();
                case OpCode.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL: return new OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL();
                case OpCode.OpSubgroupAvcRefConvertToMceResultINTEL: return new OpSubgroupAvcRefConvertToMceResultINTEL();
                case OpCode.OpSubgroupAvcSicInitializeINTEL: return new OpSubgroupAvcSicInitializeINTEL();
                case OpCode.OpSubgroupAvcSicConfigureSkcINTEL: return new OpSubgroupAvcSicConfigureSkcINTEL();
                case OpCode.OpSubgroupAvcSicConfigureIpeLumaINTEL: return new OpSubgroupAvcSicConfigureIpeLumaINTEL();
                case OpCode.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL: return new OpSubgroupAvcSicConfigureIpeLumaChromaINTEL();
                case OpCode.OpSubgroupAvcSicGetMotionVectorMaskINTEL: return new OpSubgroupAvcSicGetMotionVectorMaskINTEL();
                case OpCode.OpSubgroupAvcSicConvertToMcePayloadINTEL: return new OpSubgroupAvcSicConvertToMcePayloadINTEL();
                case OpCode.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL: return new OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL();
                case OpCode.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL: return new OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL();
                case OpCode.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL: return new OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL();
                case OpCode.OpSubgroupAvcSicSetBilinearFilterEnableINTEL: return new OpSubgroupAvcSicSetBilinearFilterEnableINTEL();
                case OpCode.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL: return new OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL();
                case OpCode.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL: return new OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL();
                case OpCode.OpSubgroupAvcSicEvaluateIpeINTEL: return new OpSubgroupAvcSicEvaluateIpeINTEL();
                case OpCode.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL: return new OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL();
                case OpCode.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL: return new OpSubgroupAvcSicEvaluateWithDualReferenceINTEL();
                case OpCode.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL: return new OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL();
                case OpCode.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL: return new OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL();
                case OpCode.OpSubgroupAvcSicConvertToMceResultINTEL: return new OpSubgroupAvcSicConvertToMceResultINTEL();
                case OpCode.OpSubgroupAvcSicGetIpeLumaShapeINTEL: return new OpSubgroupAvcSicGetIpeLumaShapeINTEL();
                case OpCode.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL: return new OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL();
                case OpCode.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL: return new OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL();
                case OpCode.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL: return new OpSubgroupAvcSicGetPackedIpeLumaModesINTEL();
                case OpCode.OpSubgroupAvcSicGetIpeChromaModeINTEL: return new OpSubgroupAvcSicGetIpeChromaModeINTEL();
                case OpCode.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL: return new OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL();
                case OpCode.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL: return new OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL();
                case OpCode.OpSubgroupAvcSicGetInterRawSadsINTEL: return new OpSubgroupAvcSicGetInterRawSadsINTEL();
                case OpCode.OpLoopControlINTEL: return new OpLoopControlINTEL();
                case OpCode.OpReadPipeBlockingINTEL: return new OpReadPipeBlockingINTEL();
                case OpCode.OpWritePipeBlockingINTEL: return new OpWritePipeBlockingINTEL();
                case OpCode.OpFPGARegINTEL: return new OpFPGARegINTEL();
                case OpCode.OpRayQueryGetRayTMinKHR: return new OpRayQueryGetRayTMinKHR();
                case OpCode.OpRayQueryGetRayFlagsKHR: return new OpRayQueryGetRayFlagsKHR();
                case OpCode.OpRayQueryGetIntersectionTKHR: return new OpRayQueryGetIntersectionTKHR();
                case OpCode.OpRayQueryGetIntersectionInstanceCustomIndexKHR: return new OpRayQueryGetIntersectionInstanceCustomIndexKHR();
                case OpCode.OpRayQueryGetIntersectionInstanceIdKHR: return new OpRayQueryGetIntersectionInstanceIdKHR();
                case OpCode.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR: return new OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR();
                case OpCode.OpRayQueryGetIntersectionGeometryIndexKHR: return new OpRayQueryGetIntersectionGeometryIndexKHR();
                case OpCode.OpRayQueryGetIntersectionPrimitiveIndexKHR: return new OpRayQueryGetIntersectionPrimitiveIndexKHR();
                case OpCode.OpRayQueryGetIntersectionBarycentricsKHR: return new OpRayQueryGetIntersectionBarycentricsKHR();
                case OpCode.OpRayQueryGetIntersectionFrontFaceKHR: return new OpRayQueryGetIntersectionFrontFaceKHR();
                case OpCode.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR: return new OpRayQueryGetIntersectionCandidateAABBOpaqueKHR();
                case OpCode.OpRayQueryGetIntersectionObjectRayDirectionKHR: return new OpRayQueryGetIntersectionObjectRayDirectionKHR();
                case OpCode.OpRayQueryGetIntersectionObjectRayOriginKHR: return new OpRayQueryGetIntersectionObjectRayOriginKHR();
                case OpCode.OpRayQueryGetWorldRayDirectionKHR: return new OpRayQueryGetWorldRayDirectionKHR();
                case OpCode.OpRayQueryGetWorldRayOriginKHR: return new OpRayQueryGetWorldRayOriginKHR();
                case OpCode.OpRayQueryGetIntersectionObjectToWorldKHR: return new OpRayQueryGetIntersectionObjectToWorldKHR();
                case OpCode.OpRayQueryGetIntersectionWorldToObjectKHR: return new OpRayQueryGetIntersectionWorldToObjectKHR();
                case OpCode.OpAtomicFAddEXT: return new OpAtomicFAddEXT();
                default: throw new InvalidDataException($"Opcode ({opcode}) does not exist!");
            }
        }
    }
    public interface IInstruction
    {
        OpCode Opcode { get; }
    }
    public class OpNop : IInstruction
    {
        public OpCode Opcode => OpCode.OpNop;
    }
    public class OpUndef : IInstruction
    {
        public OpCode Opcode => OpCode.OpUndef;
    }
    public class OpSourceContinued : IInstruction
    {
        public OpCode Opcode => OpCode.OpSourceContinued;
    }
    public class OpSource : IInstruction
    {
        public OpCode Opcode => OpCode.OpSource;
    }
    public class OpSourceExtension : IInstruction
    {
        public OpCode Opcode => OpCode.OpSourceExtension;
    }
    public class OpName : IInstruction
    {
        public OpCode Opcode => OpCode.OpName;
    }
    public class OpMemberName : IInstruction
    {
        public OpCode Opcode => OpCode.OpMemberName;
    }
    public class OpString : IInstruction
    {
        public OpCode Opcode => OpCode.OpString;
    }
    public class OpLine : IInstruction
    {
        public OpCode Opcode => OpCode.OpLine;
    }
    public class OpExtension : IInstruction
    {
        public OpCode Opcode => OpCode.OpExtension;
    }
    public class OpExtInstImport : IInstruction
    {
        public OpCode Opcode => OpCode.OpExtInstImport;
    }
    public class OpExtInst : IInstruction
    {
        public OpCode Opcode => OpCode.OpExtInst;
    }
    public class OpMemoryModel : IInstruction
    {
        public OpCode Opcode => OpCode.OpMemoryModel;
    }
    public class OpEntryPoint : IInstruction
    {
        public OpCode Opcode => OpCode.OpEntryPoint;
    }
    public class OpExecutionMode : IInstruction
    {
        public OpCode Opcode => OpCode.OpExecutionMode;
    }
    public class OpCapability : IInstruction
    {
        public OpCode Opcode => OpCode.OpCapability;
    }
    public class OpTypeVoid : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeVoid;
    }
    public class OpTypeBool : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeBool;
    }
    public class OpTypeInt : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeInt;
    }
    public class OpTypeFloat : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeFloat;
    }
    public class OpTypeVector : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeVector;
    }
    public class OpTypeMatrix : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeMatrix;
    }
    public class OpTypeImage : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeImage;
    }
    public class OpTypeSampler : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeSampler;
    }
    public class OpTypeSampledImage : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeSampledImage;
    }
    public class OpTypeArray : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeArray;
    }
    public class OpTypeRuntimeArray : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeRuntimeArray;
    }
    public class OpTypeStruct : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeStruct;
    }
    public class OpTypeOpaque : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeOpaque;
    }
    public class OpTypePointer : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypePointer;
    }
    public class OpTypeFunction : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeFunction;
    }
    public class OpTypeEvent : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeEvent;
    }
    public class OpTypeDeviceEvent : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeDeviceEvent;
    }
    public class OpTypeReserveId : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeReserveId;
    }
    public class OpTypeQueue : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeQueue;
    }
    public class OpTypePipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypePipe;
    }
    public class OpTypeForwardPointer : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeForwardPointer;
    }
    public class OpConstantTrue : IInstruction
    {
        public OpCode Opcode => OpCode.OpConstantTrue;
    }
    public class OpConstantFalse : IInstruction
    {
        public OpCode Opcode => OpCode.OpConstantFalse;
    }
    public class OpConstant : IInstruction
    {
        public OpCode Opcode => OpCode.OpConstant;
    }
    public class OpConstantComposite : IInstruction
    {
        public OpCode Opcode => OpCode.OpConstantComposite;
    }
    public class OpConstantSampler : IInstruction
    {
        public OpCode Opcode => OpCode.OpConstantSampler;
    }
    public class OpConstantNull : IInstruction
    {
        public OpCode Opcode => OpCode.OpConstantNull;
    }
    public class OpSpecConstantTrue : IInstruction
    {
        public OpCode Opcode => OpCode.OpSpecConstantTrue;
    }
    public class OpSpecConstantFalse : IInstruction
    {
        public OpCode Opcode => OpCode.OpSpecConstantFalse;
    }
    public class OpSpecConstant : IInstruction
    {
        public OpCode Opcode => OpCode.OpSpecConstant;
    }
    public class OpSpecConstantComposite : IInstruction
    {
        public OpCode Opcode => OpCode.OpSpecConstantComposite;
    }
    public class OpSpecConstantOp : IInstruction
    {
        public OpCode Opcode => OpCode.OpSpecConstantOp;
    }
    public class OpFunction : IInstruction
    {
        public OpCode Opcode => OpCode.OpFunction;
    }
    public class OpFunctionParameter : IInstruction
    {
        public OpCode Opcode => OpCode.OpFunctionParameter;
    }
    public class OpFunctionEnd : IInstruction
    {
        public OpCode Opcode => OpCode.OpFunctionEnd;
    }
    public class OpFunctionCall : IInstruction
    {
        public OpCode Opcode => OpCode.OpFunctionCall;
    }
    public class OpVariable : IInstruction
    {
        public OpCode Opcode => OpCode.OpVariable;
    }
    public class OpImageTexelPointer : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageTexelPointer;
    }
    public class OpLoad : IInstruction
    {
        public OpCode Opcode => OpCode.OpLoad;
    }
    public class OpStore : IInstruction
    {
        public OpCode Opcode => OpCode.OpStore;
    }
    public class OpCopyMemory : IInstruction
    {
        public OpCode Opcode => OpCode.OpCopyMemory;
    }
    public class OpCopyMemorySized : IInstruction
    {
        public OpCode Opcode => OpCode.OpCopyMemorySized;
    }
    public class OpAccessChain : IInstruction
    {
        public OpCode Opcode => OpCode.OpAccessChain;
    }
    public class OpInBoundsAccessChain : IInstruction
    {
        public OpCode Opcode => OpCode.OpInBoundsAccessChain;
    }
    public class OpPtrAccessChain : IInstruction
    {
        public OpCode Opcode => OpCode.OpPtrAccessChain;
    }
    public class OpArrayLength : IInstruction
    {
        public OpCode Opcode => OpCode.OpArrayLength;
    }
    public class OpGenericPtrMemSemantics : IInstruction
    {
        public OpCode Opcode => OpCode.OpGenericPtrMemSemantics;
    }
    public class OpInBoundsPtrAccessChain : IInstruction
    {
        public OpCode Opcode => OpCode.OpInBoundsPtrAccessChain;
    }
    public class OpDecorate : IInstruction
    {
        public OpCode Opcode => OpCode.OpDecorate;
    }
    public class OpMemberDecorate : IInstruction
    {
        public OpCode Opcode => OpCode.OpMemberDecorate;
    }
    public class OpDecorationGroup : IInstruction
    {
        public OpCode Opcode => OpCode.OpDecorationGroup;
    }
    public class OpGroupDecorate : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupDecorate;
    }
    public class OpGroupMemberDecorate : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupMemberDecorate;
    }
    public class OpVectorExtractDynamic : IInstruction
    {
        public OpCode Opcode => OpCode.OpVectorExtractDynamic;
    }
    public class OpVectorInsertDynamic : IInstruction
    {
        public OpCode Opcode => OpCode.OpVectorInsertDynamic;
    }
    public class OpVectorShuffle : IInstruction
    {
        public OpCode Opcode => OpCode.OpVectorShuffle;
    }
    public class OpCompositeConstruct : IInstruction
    {
        public OpCode Opcode => OpCode.OpCompositeConstruct;
    }
    public class OpCompositeExtract : IInstruction
    {
        public OpCode Opcode => OpCode.OpCompositeExtract;
    }
    public class OpCompositeInsert : IInstruction
    {
        public OpCode Opcode => OpCode.OpCompositeInsert;
    }
    public class OpCopyObject : IInstruction
    {
        public OpCode Opcode => OpCode.OpCopyObject;
    }
    public class OpTranspose : IInstruction
    {
        public OpCode Opcode => OpCode.OpTranspose;
    }
    public class OpSampledImage : IInstruction
    {
        public OpCode Opcode => OpCode.OpSampledImage;
    }
    public class OpImageSampleImplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleImplicitLod;
    }
    public class OpImageSampleExplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleExplicitLod;
    }
    public class OpImageSampleDrefImplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleDrefImplicitLod;
    }
    public class OpImageSampleDrefExplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleDrefExplicitLod;
    }
    public class OpImageSampleProjImplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleProjImplicitLod;
    }
    public class OpImageSampleProjExplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleProjExplicitLod;
    }
    public class OpImageSampleProjDrefImplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleProjDrefImplicitLod;
    }
    public class OpImageSampleProjDrefExplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleProjDrefExplicitLod;
    }
    public class OpImageFetch : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageFetch;
    }
    public class OpImageGather : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageGather;
    }
    public class OpImageDrefGather : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageDrefGather;
    }
    public class OpImageRead : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageRead;
    }
    public class OpImageWrite : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageWrite;
    }
    public class OpImage : IInstruction
    {
        public OpCode Opcode => OpCode.OpImage;
    }
    public class OpImageQueryFormat : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageQueryFormat;
    }
    public class OpImageQueryOrder : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageQueryOrder;
    }
    public class OpImageQuerySizeLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageQuerySizeLod;
    }
    public class OpImageQuerySize : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageQuerySize;
    }
    public class OpImageQueryLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageQueryLod;
    }
    public class OpImageQueryLevels : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageQueryLevels;
    }
    public class OpImageQuerySamples : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageQuerySamples;
    }
    public class OpConvertFToU : IInstruction
    {
        public OpCode Opcode => OpCode.OpConvertFToU;
    }
    public class OpConvertFToS : IInstruction
    {
        public OpCode Opcode => OpCode.OpConvertFToS;
    }
    public class OpConvertSToF : IInstruction
    {
        public OpCode Opcode => OpCode.OpConvertSToF;
    }
    public class OpConvertUToF : IInstruction
    {
        public OpCode Opcode => OpCode.OpConvertUToF;
    }
    public class OpUConvert : IInstruction
    {
        public OpCode Opcode => OpCode.OpUConvert;
    }
    public class OpSConvert : IInstruction
    {
        public OpCode Opcode => OpCode.OpSConvert;
    }
    public class OpFConvert : IInstruction
    {
        public OpCode Opcode => OpCode.OpFConvert;
    }
    public class OpQuantizeToF16 : IInstruction
    {
        public OpCode Opcode => OpCode.OpQuantizeToF16;
    }
    public class OpConvertPtrToU : IInstruction
    {
        public OpCode Opcode => OpCode.OpConvertPtrToU;
    }
    public class OpSatConvertSToU : IInstruction
    {
        public OpCode Opcode => OpCode.OpSatConvertSToU;
    }
    public class OpSatConvertUToS : IInstruction
    {
        public OpCode Opcode => OpCode.OpSatConvertUToS;
    }
    public class OpConvertUToPtr : IInstruction
    {
        public OpCode Opcode => OpCode.OpConvertUToPtr;
    }
    public class OpPtrCastToGeneric : IInstruction
    {
        public OpCode Opcode => OpCode.OpPtrCastToGeneric;
    }
    public class OpGenericCastToPtr : IInstruction
    {
        public OpCode Opcode => OpCode.OpGenericCastToPtr;
    }
    public class OpGenericCastToPtrExplicit : IInstruction
    {
        public OpCode Opcode => OpCode.OpGenericCastToPtrExplicit;
    }
    public class OpBitcast : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitcast;
    }
    public class OpSNegate : IInstruction
    {
        public OpCode Opcode => OpCode.OpSNegate;
    }
    public class OpFNegate : IInstruction
    {
        public OpCode Opcode => OpCode.OpFNegate;
    }
    public class OpIAdd : IInstruction
    {
        public OpCode Opcode => OpCode.OpIAdd;
    }
    public class OpFAdd : IInstruction
    {
        public OpCode Opcode => OpCode.OpFAdd;
    }
    public class OpISub : IInstruction
    {
        public OpCode Opcode => OpCode.OpISub;
    }
    public class OpFSub : IInstruction
    {
        public OpCode Opcode => OpCode.OpFSub;
    }
    public class OpIMul : IInstruction
    {
        public OpCode Opcode => OpCode.OpIMul;
    }
    public class OpFMul : IInstruction
    {
        public OpCode Opcode => OpCode.OpFMul;
    }
    public class OpUDiv : IInstruction
    {
        public OpCode Opcode => OpCode.OpUDiv;
    }
    public class OpSDiv : IInstruction
    {
        public OpCode Opcode => OpCode.OpSDiv;
    }
    public class OpFDiv : IInstruction
    {
        public OpCode Opcode => OpCode.OpFDiv;
    }
    public class OpUMod : IInstruction
    {
        public OpCode Opcode => OpCode.OpUMod;
    }
    public class OpSRem : IInstruction
    {
        public OpCode Opcode => OpCode.OpSRem;
    }
    public class OpSMod : IInstruction
    {
        public OpCode Opcode => OpCode.OpSMod;
    }
    public class OpFRem : IInstruction
    {
        public OpCode Opcode => OpCode.OpFRem;
    }
    public class OpFMod : IInstruction
    {
        public OpCode Opcode => OpCode.OpFMod;
    }
    public class OpVectorTimesScalar : IInstruction
    {
        public OpCode Opcode => OpCode.OpVectorTimesScalar;
    }
    public class OpMatrixTimesScalar : IInstruction
    {
        public OpCode Opcode => OpCode.OpMatrixTimesScalar;
    }
    public class OpVectorTimesMatrix : IInstruction
    {
        public OpCode Opcode => OpCode.OpVectorTimesMatrix;
    }
    public class OpMatrixTimesVector : IInstruction
    {
        public OpCode Opcode => OpCode.OpMatrixTimesVector;
    }
    public class OpMatrixTimesMatrix : IInstruction
    {
        public OpCode Opcode => OpCode.OpMatrixTimesMatrix;
    }
    public class OpOuterProduct : IInstruction
    {
        public OpCode Opcode => OpCode.OpOuterProduct;
    }
    public class OpDot : IInstruction
    {
        public OpCode Opcode => OpCode.OpDot;
    }
    public class OpIAddCarry : IInstruction
    {
        public OpCode Opcode => OpCode.OpIAddCarry;
    }
    public class OpISubBorrow : IInstruction
    {
        public OpCode Opcode => OpCode.OpISubBorrow;
    }
    public class OpUMulExtended : IInstruction
    {
        public OpCode Opcode => OpCode.OpUMulExtended;
    }
    public class OpSMulExtended : IInstruction
    {
        public OpCode Opcode => OpCode.OpSMulExtended;
    }
    public class OpAny : IInstruction
    {
        public OpCode Opcode => OpCode.OpAny;
    }
    public class OpAll : IInstruction
    {
        public OpCode Opcode => OpCode.OpAll;
    }
    public class OpIsNan : IInstruction
    {
        public OpCode Opcode => OpCode.OpIsNan;
    }
    public class OpIsInf : IInstruction
    {
        public OpCode Opcode => OpCode.OpIsInf;
    }
    public class OpIsFinite : IInstruction
    {
        public OpCode Opcode => OpCode.OpIsFinite;
    }
    public class OpIsNormal : IInstruction
    {
        public OpCode Opcode => OpCode.OpIsNormal;
    }
    public class OpSignBitSet : IInstruction
    {
        public OpCode Opcode => OpCode.OpSignBitSet;
    }
    public class OpLessOrGreater : IInstruction
    {
        public OpCode Opcode => OpCode.OpLessOrGreater;
    }
    public class OpOrdered : IInstruction
    {
        public OpCode Opcode => OpCode.OpOrdered;
    }
    public class OpUnordered : IInstruction
    {
        public OpCode Opcode => OpCode.OpUnordered;
    }
    public class OpLogicalEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpLogicalEqual;
    }
    public class OpLogicalNotEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpLogicalNotEqual;
    }
    public class OpLogicalOr : IInstruction
    {
        public OpCode Opcode => OpCode.OpLogicalOr;
    }
    public class OpLogicalAnd : IInstruction
    {
        public OpCode Opcode => OpCode.OpLogicalAnd;
    }
    public class OpLogicalNot : IInstruction
    {
        public OpCode Opcode => OpCode.OpLogicalNot;
    }
    public class OpSelect : IInstruction
    {
        public OpCode Opcode => OpCode.OpSelect;
    }
    public class OpIEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpIEqual;
    }
    public class OpINotEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpINotEqual;
    }
    public class OpUGreaterThan : IInstruction
    {
        public OpCode Opcode => OpCode.OpUGreaterThan;
    }
    public class OpSGreaterThan : IInstruction
    {
        public OpCode Opcode => OpCode.OpSGreaterThan;
    }
    public class OpUGreaterThanEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpUGreaterThanEqual;
    }
    public class OpSGreaterThanEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpSGreaterThanEqual;
    }
    public class OpULessThan : IInstruction
    {
        public OpCode Opcode => OpCode.OpULessThan;
    }
    public class OpSLessThan : IInstruction
    {
        public OpCode Opcode => OpCode.OpSLessThan;
    }
    public class OpULessThanEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpULessThanEqual;
    }
    public class OpSLessThanEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpSLessThanEqual;
    }
    public class OpFOrdEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpFOrdEqual;
    }
    public class OpFUnordEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpFUnordEqual;
    }
    public class OpFOrdNotEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpFOrdNotEqual;
    }
    public class OpFUnordNotEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpFUnordNotEqual;
    }
    public class OpFOrdLessThan : IInstruction
    {
        public OpCode Opcode => OpCode.OpFOrdLessThan;
    }
    public class OpFUnordLessThan : IInstruction
    {
        public OpCode Opcode => OpCode.OpFUnordLessThan;
    }
    public class OpFOrdGreaterThan : IInstruction
    {
        public OpCode Opcode => OpCode.OpFOrdGreaterThan;
    }
    public class OpFUnordGreaterThan : IInstruction
    {
        public OpCode Opcode => OpCode.OpFUnordGreaterThan;
    }
    public class OpFOrdLessThanEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpFOrdLessThanEqual;
    }
    public class OpFUnordLessThanEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpFUnordLessThanEqual;
    }
    public class OpFOrdGreaterThanEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpFOrdGreaterThanEqual;
    }
    public class OpFUnordGreaterThanEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpFUnordGreaterThanEqual;
    }
    public class OpShiftRightLogical : IInstruction
    {
        public OpCode Opcode => OpCode.OpShiftRightLogical;
    }
    public class OpShiftRightArithmetic : IInstruction
    {
        public OpCode Opcode => OpCode.OpShiftRightArithmetic;
    }
    public class OpShiftLeftLogical : IInstruction
    {
        public OpCode Opcode => OpCode.OpShiftLeftLogical;
    }
    public class OpBitwiseOr : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitwiseOr;
    }
    public class OpBitwiseXor : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitwiseXor;
    }
    public class OpBitwiseAnd : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitwiseAnd;
    }
    public class OpNot : IInstruction
    {
        public OpCode Opcode => OpCode.OpNot;
    }
    public class OpBitFieldInsert : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitFieldInsert;
    }
    public class OpBitFieldSExtract : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitFieldSExtract;
    }
    public class OpBitFieldUExtract : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitFieldUExtract;
    }
    public class OpBitReverse : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitReverse;
    }
    public class OpBitCount : IInstruction
    {
        public OpCode Opcode => OpCode.OpBitCount;
    }
    public class OpDPdx : IInstruction
    {
        public OpCode Opcode => OpCode.OpDPdx;
    }
    public class OpDPdy : IInstruction
    {
        public OpCode Opcode => OpCode.OpDPdy;
    }
    public class OpFwidth : IInstruction
    {
        public OpCode Opcode => OpCode.OpFwidth;
    }
    public class OpDPdxFine : IInstruction
    {
        public OpCode Opcode => OpCode.OpDPdxFine;
    }
    public class OpDPdyFine : IInstruction
    {
        public OpCode Opcode => OpCode.OpDPdyFine;
    }
    public class OpFwidthFine : IInstruction
    {
        public OpCode Opcode => OpCode.OpFwidthFine;
    }
    public class OpDPdxCoarse : IInstruction
    {
        public OpCode Opcode => OpCode.OpDPdxCoarse;
    }
    public class OpDPdyCoarse : IInstruction
    {
        public OpCode Opcode => OpCode.OpDPdyCoarse;
    }
    public class OpFwidthCoarse : IInstruction
    {
        public OpCode Opcode => OpCode.OpFwidthCoarse;
    }
    public class OpEmitVertex : IInstruction
    {
        public OpCode Opcode => OpCode.OpEmitVertex;
    }
    public class OpEndPrimitive : IInstruction
    {
        public OpCode Opcode => OpCode.OpEndPrimitive;
    }
    public class OpEmitStreamVertex : IInstruction
    {
        public OpCode Opcode => OpCode.OpEmitStreamVertex;
    }
    public class OpEndStreamPrimitive : IInstruction
    {
        public OpCode Opcode => OpCode.OpEndStreamPrimitive;
    }
    public class OpControlBarrier : IInstruction
    {
        public OpCode Opcode => OpCode.OpControlBarrier;
    }
    public class OpMemoryBarrier : IInstruction
    {
        public OpCode Opcode => OpCode.OpMemoryBarrier;
    }
    public class OpAtomicLoad : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicLoad;
    }
    public class OpAtomicStore : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicStore;
    }
    public class OpAtomicExchange : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicExchange;
    }
    public class OpAtomicCompareExchange : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicCompareExchange;
    }
    public class OpAtomicCompareExchangeWeak : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicCompareExchangeWeak;
    }
    public class OpAtomicIIncrement : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicIIncrement;
    }
    public class OpAtomicIDecrement : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicIDecrement;
    }
    public class OpAtomicIAdd : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicIAdd;
    }
    public class OpAtomicISub : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicISub;
    }
    public class OpAtomicSMin : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicSMin;
    }
    public class OpAtomicUMin : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicUMin;
    }
    public class OpAtomicSMax : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicSMax;
    }
    public class OpAtomicUMax : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicUMax;
    }
    public class OpAtomicAnd : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicAnd;
    }
    public class OpAtomicOr : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicOr;
    }
    public class OpAtomicXor : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicXor;
    }
    public class OpPhi : IInstruction
    {
        public OpCode Opcode => OpCode.OpPhi;
    }
    public class OpLoopMerge : IInstruction
    {
        public OpCode Opcode => OpCode.OpLoopMerge;
    }
    public class OpSelectionMerge : IInstruction
    {
        public OpCode Opcode => OpCode.OpSelectionMerge;
    }
    public class OpLabel : IInstruction
    {
        public OpCode Opcode => OpCode.OpLabel;
    }
    public class OpBranch : IInstruction
    {
        public OpCode Opcode => OpCode.OpBranch;
    }
    public class OpBranchConditional : IInstruction
    {
        public OpCode Opcode => OpCode.OpBranchConditional;
    }
    public class OpSwitch : IInstruction
    {
        public OpCode Opcode => OpCode.OpSwitch;
    }
    public class OpKill : IInstruction
    {
        public OpCode Opcode => OpCode.OpKill;
    }
    public class OpReturn : IInstruction
    {
        public OpCode Opcode => OpCode.OpReturn;
    }
    public class OpReturnValue : IInstruction
    {
        public OpCode Opcode => OpCode.OpReturnValue;
    }
    public class OpUnreachable : IInstruction
    {
        public OpCode Opcode => OpCode.OpUnreachable;
    }
    public class OpLifetimeStart : IInstruction
    {
        public OpCode Opcode => OpCode.OpLifetimeStart;
    }
    public class OpLifetimeStop : IInstruction
    {
        public OpCode Opcode => OpCode.OpLifetimeStop;
    }
    public class OpGroupAsyncCopy : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupAsyncCopy;
    }
    public class OpGroupWaitEvents : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupWaitEvents;
    }
    public class OpGroupAll : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupAll;
    }
    public class OpGroupAny : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupAny;
    }
    public class OpGroupBroadcast : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupBroadcast;
    }
    public class OpGroupIAdd : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupIAdd;
    }
    public class OpGroupFAdd : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupFAdd;
    }
    public class OpGroupFMin : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupFMin;
    }
    public class OpGroupUMin : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupUMin;
    }
    public class OpGroupSMin : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupSMin;
    }
    public class OpGroupFMax : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupFMax;
    }
    public class OpGroupUMax : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupUMax;
    }
    public class OpGroupSMax : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupSMax;
    }
    public class OpReadPipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpReadPipe;
    }
    public class OpWritePipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpWritePipe;
    }
    public class OpReservedReadPipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpReservedReadPipe;
    }
    public class OpReservedWritePipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpReservedWritePipe;
    }
    public class OpReserveReadPipePackets : IInstruction
    {
        public OpCode Opcode => OpCode.OpReserveReadPipePackets;
    }
    public class OpReserveWritePipePackets : IInstruction
    {
        public OpCode Opcode => OpCode.OpReserveWritePipePackets;
    }
    public class OpCommitReadPipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpCommitReadPipe;
    }
    public class OpCommitWritePipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpCommitWritePipe;
    }
    public class OpIsValidReserveId : IInstruction
    {
        public OpCode Opcode => OpCode.OpIsValidReserveId;
    }
    public class OpGetNumPipePackets : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetNumPipePackets;
    }
    public class OpGetMaxPipePackets : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetMaxPipePackets;
    }
    public class OpGroupReserveReadPipePackets : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupReserveReadPipePackets;
    }
    public class OpGroupReserveWritePipePackets : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupReserveWritePipePackets;
    }
    public class OpGroupCommitReadPipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupCommitReadPipe;
    }
    public class OpGroupCommitWritePipe : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupCommitWritePipe;
    }
    public class OpEnqueueMarker : IInstruction
    {
        public OpCode Opcode => OpCode.OpEnqueueMarker;
    }
    public class OpEnqueueKernel : IInstruction
    {
        public OpCode Opcode => OpCode.OpEnqueueKernel;
    }
    public class OpGetKernelNDrangeSubGroupCount : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetKernelNDrangeSubGroupCount;
    }
    public class OpGetKernelNDrangeMaxSubGroupSize : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetKernelNDrangeMaxSubGroupSize;
    }
    public class OpGetKernelWorkGroupSize : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetKernelWorkGroupSize;
    }
    public class OpGetKernelPreferredWorkGroupSizeMultiple : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetKernelPreferredWorkGroupSizeMultiple;
    }
    public class OpRetainEvent : IInstruction
    {
        public OpCode Opcode => OpCode.OpRetainEvent;
    }
    public class OpReleaseEvent : IInstruction
    {
        public OpCode Opcode => OpCode.OpReleaseEvent;
    }
    public class OpCreateUserEvent : IInstruction
    {
        public OpCode Opcode => OpCode.OpCreateUserEvent;
    }
    public class OpIsValidEvent : IInstruction
    {
        public OpCode Opcode => OpCode.OpIsValidEvent;
    }
    public class OpSetUserEventStatus : IInstruction
    {
        public OpCode Opcode => OpCode.OpSetUserEventStatus;
    }
    public class OpCaptureEventProfilingInfo : IInstruction
    {
        public OpCode Opcode => OpCode.OpCaptureEventProfilingInfo;
    }
    public class OpGetDefaultQueue : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetDefaultQueue;
    }
    public class OpBuildNDRange : IInstruction
    {
        public OpCode Opcode => OpCode.OpBuildNDRange;
    }
    public class OpImageSparseSampleImplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseSampleImplicitLod;
    }
    public class OpImageSparseSampleExplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseSampleExplicitLod;
    }
    public class OpImageSparseSampleDrefImplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseSampleDrefImplicitLod;
    }
    public class OpImageSparseSampleDrefExplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseSampleDrefExplicitLod;
    }
    public class OpImageSparseSampleProjImplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseSampleProjImplicitLod;
    }
    public class OpImageSparseSampleProjExplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseSampleProjExplicitLod;
    }
    public class OpImageSparseSampleProjDrefImplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseSampleProjDrefImplicitLod;
    }
    public class OpImageSparseSampleProjDrefExplicitLod : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseSampleProjDrefExplicitLod;
    }
    public class OpImageSparseFetch : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseFetch;
    }
    public class OpImageSparseGather : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseGather;
    }
    public class OpImageSparseDrefGather : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseDrefGather;
    }
    public class OpImageSparseTexelsResident : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseTexelsResident;
    }
    public class OpNoLine : IInstruction
    {
        public OpCode Opcode => OpCode.OpNoLine;
    }
    public class OpAtomicFlagTestAndSet : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicFlagTestAndSet;
    }
    public class OpAtomicFlagClear : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicFlagClear;
    }
    public class OpImageSparseRead : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSparseRead;
    }
    public class OpSizeOf : IInstruction
    {
        public OpCode Opcode => OpCode.OpSizeOf;
    }
    public class OpTypePipeStorage : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypePipeStorage;
    }
    public class OpConstantPipeStorage : IInstruction
    {
        public OpCode Opcode => OpCode.OpConstantPipeStorage;
    }
    public class OpCreatePipeFromPipeStorage : IInstruction
    {
        public OpCode Opcode => OpCode.OpCreatePipeFromPipeStorage;
    }
    public class OpGetKernelLocalSizeForSubgroupCount : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetKernelLocalSizeForSubgroupCount;
    }
    public class OpGetKernelMaxNumSubgroups : IInstruction
    {
        public OpCode Opcode => OpCode.OpGetKernelMaxNumSubgroups;
    }
    public class OpTypeNamedBarrier : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeNamedBarrier;
    }
    public class OpNamedBarrierInitialize : IInstruction
    {
        public OpCode Opcode => OpCode.OpNamedBarrierInitialize;
    }
    public class OpMemoryNamedBarrier : IInstruction
    {
        public OpCode Opcode => OpCode.OpMemoryNamedBarrier;
    }
    public class OpModuleProcessed : IInstruction
    {
        public OpCode Opcode => OpCode.OpModuleProcessed;
    }
    public class OpExecutionModeId : IInstruction
    {
        public OpCode Opcode => OpCode.OpExecutionModeId;
    }
    public class OpDecorateId : IInstruction
    {
        public OpCode Opcode => OpCode.OpDecorateId;
    }
    public class OpGroupNonUniformElect : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformElect;
    }
    public class OpGroupNonUniformAll : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformAll;
    }
    public class OpGroupNonUniformAny : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformAny;
    }
    public class OpGroupNonUniformAllEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformAllEqual;
    }
    public class OpGroupNonUniformBroadcast : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBroadcast;
    }
    public class OpGroupNonUniformBroadcastFirst : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBroadcastFirst;
    }
    public class OpGroupNonUniformBallot : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBallot;
    }
    public class OpGroupNonUniformInverseBallot : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformInverseBallot;
    }
    public class OpGroupNonUniformBallotBitExtract : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBallotBitExtract;
    }
    public class OpGroupNonUniformBallotBitCount : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBallotBitCount;
    }
    public class OpGroupNonUniformBallotFindLSB : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBallotFindLSB;
    }
    public class OpGroupNonUniformBallotFindMSB : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBallotFindMSB;
    }
    public class OpGroupNonUniformShuffle : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformShuffle;
    }
    public class OpGroupNonUniformShuffleXor : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformShuffleXor;
    }
    public class OpGroupNonUniformShuffleUp : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformShuffleUp;
    }
    public class OpGroupNonUniformShuffleDown : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformShuffleDown;
    }
    public class OpGroupNonUniformIAdd : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformIAdd;
    }
    public class OpGroupNonUniformFAdd : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformFAdd;
    }
    public class OpGroupNonUniformIMul : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformIMul;
    }
    public class OpGroupNonUniformFMul : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformFMul;
    }
    public class OpGroupNonUniformSMin : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformSMin;
    }
    public class OpGroupNonUniformUMin : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformUMin;
    }
    public class OpGroupNonUniformFMin : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformFMin;
    }
    public class OpGroupNonUniformSMax : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformSMax;
    }
    public class OpGroupNonUniformUMax : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformUMax;
    }
    public class OpGroupNonUniformFMax : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformFMax;
    }
    public class OpGroupNonUniformBitwiseAnd : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBitwiseAnd;
    }
    public class OpGroupNonUniformBitwiseOr : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBitwiseOr;
    }
    public class OpGroupNonUniformBitwiseXor : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformBitwiseXor;
    }
    public class OpGroupNonUniformLogicalAnd : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformLogicalAnd;
    }
    public class OpGroupNonUniformLogicalOr : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformLogicalOr;
    }
    public class OpGroupNonUniformLogicalXor : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformLogicalXor;
    }
    public class OpGroupNonUniformQuadBroadcast : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformQuadBroadcast;
    }
    public class OpGroupNonUniformQuadSwap : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformQuadSwap;
    }
    public class OpCopyLogical : IInstruction
    {
        public OpCode Opcode => OpCode.OpCopyLogical;
    }
    public class OpPtrEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpPtrEqual;
    }
    public class OpPtrNotEqual : IInstruction
    {
        public OpCode Opcode => OpCode.OpPtrNotEqual;
    }
    public class OpPtrDiff : IInstruction
    {
        public OpCode Opcode => OpCode.OpPtrDiff;
    }
    public class OpTerminateInvocation : IInstruction
    {
        public OpCode Opcode => OpCode.OpTerminateInvocation;
    }
    public class OpSubgroupBallotKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupBallotKHR;
    }
    public class OpSubgroupFirstInvocationKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupFirstInvocationKHR;
    }
    public class OpSubgroupAllKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAllKHR;
    }
    public class OpSubgroupAnyKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAnyKHR;
    }
    public class OpSubgroupAllEqualKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAllEqualKHR;
    }
    public class OpSubgroupReadInvocationKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupReadInvocationKHR;
    }
    public class OpTypeRayQueryProvisionalKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeRayQueryProvisionalKHR;
    }
    public class OpRayQueryInitializeKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryInitializeKHR;
    }
    public class OpRayQueryTerminateKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryTerminateKHR;
    }
    public class OpRayQueryGenerateIntersectionKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGenerateIntersectionKHR;
    }
    public class OpRayQueryConfirmIntersectionKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryConfirmIntersectionKHR;
    }
    public class OpRayQueryProceedKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryProceedKHR;
    }
    public class OpRayQueryGetIntersectionTypeKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionTypeKHR;
    }
    public class OpGroupIAddNonUniformAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupIAddNonUniformAMD;
    }
    public class OpGroupFAddNonUniformAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupFAddNonUniformAMD;
    }
    public class OpGroupFMinNonUniformAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupFMinNonUniformAMD;
    }
    public class OpGroupUMinNonUniformAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupUMinNonUniformAMD;
    }
    public class OpGroupSMinNonUniformAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupSMinNonUniformAMD;
    }
    public class OpGroupFMaxNonUniformAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupFMaxNonUniformAMD;
    }
    public class OpGroupUMaxNonUniformAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupUMaxNonUniformAMD;
    }
    public class OpGroupSMaxNonUniformAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupSMaxNonUniformAMD;
    }
    public class OpFragmentMaskFetchAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpFragmentMaskFetchAMD;
    }
    public class OpFragmentFetchAMD : IInstruction
    {
        public OpCode Opcode => OpCode.OpFragmentFetchAMD;
    }
    public class OpReadClockKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpReadClockKHR;
    }
    public class OpImageSampleFootprintNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpImageSampleFootprintNV;
    }
    public class OpGroupNonUniformPartitionNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpGroupNonUniformPartitionNV;
    }
    public class OpWritePackedPrimitiveIndices4x8NV : IInstruction
    {
        public OpCode Opcode => OpCode.OpWritePackedPrimitiveIndices4x8NV;
    }
    public class OpReportIntersectionNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpReportIntersectionNV;
    }
    public class OpReportIntersectionKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpReportIntersectionKHR;
    }
    public class OpIgnoreIntersectionNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpIgnoreIntersectionNV;
    }
    public class OpIgnoreIntersectionKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpIgnoreIntersectionKHR;
    }
    public class OpTerminateRayNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpTerminateRayNV;
    }
    public class OpTerminateRayKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpTerminateRayKHR;
    }
    public class OpTraceNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpTraceNV;
    }
    public class OpTraceRayKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpTraceRayKHR;
    }
    public class OpTypeAccelerationStructureNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAccelerationStructureNV;
    }
    public class OpTypeAccelerationStructureKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAccelerationStructureKHR;
    }
    public class OpExecuteCallableNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpExecuteCallableNV;
    }
    public class OpExecuteCallableKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpExecuteCallableKHR;
    }
    public class OpTypeCooperativeMatrixNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeCooperativeMatrixNV;
    }
    public class OpCooperativeMatrixLoadNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpCooperativeMatrixLoadNV;
    }
    public class OpCooperativeMatrixStoreNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpCooperativeMatrixStoreNV;
    }
    public class OpCooperativeMatrixMulAddNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpCooperativeMatrixMulAddNV;
    }
    public class OpCooperativeMatrixLengthNV : IInstruction
    {
        public OpCode Opcode => OpCode.OpCooperativeMatrixLengthNV;
    }
    public class OpBeginInvocationInterlockEXT : IInstruction
    {
        public OpCode Opcode => OpCode.OpBeginInvocationInterlockEXT;
    }
    public class OpEndInvocationInterlockEXT : IInstruction
    {
        public OpCode Opcode => OpCode.OpEndInvocationInterlockEXT;
    }
    public class OpDemoteToHelperInvocationEXT : IInstruction
    {
        public OpCode Opcode => OpCode.OpDemoteToHelperInvocationEXT;
    }
    public class OpIsHelperInvocationEXT : IInstruction
    {
        public OpCode Opcode => OpCode.OpIsHelperInvocationEXT;
    }
    public class OpSubgroupShuffleINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupShuffleINTEL;
    }
    public class OpSubgroupShuffleDownINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupShuffleDownINTEL;
    }
    public class OpSubgroupShuffleUpINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupShuffleUpINTEL;
    }
    public class OpSubgroupShuffleXorINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupShuffleXorINTEL;
    }
    public class OpSubgroupBlockReadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupBlockReadINTEL;
    }
    public class OpSubgroupBlockWriteINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupBlockWriteINTEL;
    }
    public class OpSubgroupImageBlockReadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupImageBlockReadINTEL;
    }
    public class OpSubgroupImageBlockWriteINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupImageBlockWriteINTEL;
    }
    public class OpSubgroupImageMediaBlockReadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupImageMediaBlockReadINTEL;
    }
    public class OpSubgroupImageMediaBlockWriteINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupImageMediaBlockWriteINTEL;
    }
    public class OpUCountLeadingZerosINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpUCountLeadingZerosINTEL;
    }
    public class OpUCountTrailingZerosINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpUCountTrailingZerosINTEL;
    }
    public class OpAbsISubINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpAbsISubINTEL;
    }
    public class OpAbsUSubINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpAbsUSubINTEL;
    }
    public class OpIAddSatINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpIAddSatINTEL;
    }
    public class OpUAddSatINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpUAddSatINTEL;
    }
    public class OpIAverageINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpIAverageINTEL;
    }
    public class OpUAverageINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpUAverageINTEL;
    }
    public class OpIAverageRoundedINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpIAverageRoundedINTEL;
    }
    public class OpUAverageRoundedINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpUAverageRoundedINTEL;
    }
    public class OpISubSatINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpISubSatINTEL;
    }
    public class OpUSubSatINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpUSubSatINTEL;
    }
    public class OpIMul32x16INTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpIMul32x16INTEL;
    }
    public class OpUMul32x16INTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpUMul32x16INTEL;
    }
    public class OpFunctionPointerINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpFunctionPointerINTEL;
    }
    public class OpFunctionPointerCallINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpFunctionPointerCallINTEL;
    }
    public class OpDecorateString : IInstruction
    {
        public OpCode Opcode => OpCode.OpDecorateString;
    }
    public class OpDecorateStringGOOGLE : IInstruction
    {
        public OpCode Opcode => OpCode.OpDecorateStringGOOGLE;
    }
    public class OpMemberDecorateString : IInstruction
    {
        public OpCode Opcode => OpCode.OpMemberDecorateString;
    }
    public class OpMemberDecorateStringGOOGLE : IInstruction
    {
        public OpCode Opcode => OpCode.OpMemberDecorateStringGOOGLE;
    }
    public class OpVmeImageINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpVmeImageINTEL;
    }
    public class OpTypeVmeImageINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeVmeImageINTEL;
    }
    public class OpTypeAvcImePayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcImePayloadINTEL;
    }
    public class OpTypeAvcRefPayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcRefPayloadINTEL;
    }
    public class OpTypeAvcSicPayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcSicPayloadINTEL;
    }
    public class OpTypeAvcMcePayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcMcePayloadINTEL;
    }
    public class OpTypeAvcMceResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcMceResultINTEL;
    }
    public class OpTypeAvcImeResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcImeResultINTEL;
    }
    public class OpTypeAvcImeResultSingleReferenceStreamoutINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcImeResultSingleReferenceStreamoutINTEL;
    }
    public class OpTypeAvcImeResultDualReferenceStreamoutINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcImeResultDualReferenceStreamoutINTEL;
    }
    public class OpTypeAvcImeSingleReferenceStreaminINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcImeSingleReferenceStreaminINTEL;
    }
    public class OpTypeAvcImeDualReferenceStreaminINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcImeDualReferenceStreaminINTEL;
    }
    public class OpTypeAvcRefResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcRefResultINTEL;
    }
    public class OpTypeAvcSicResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpTypeAvcSicResultINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL;
    }
    public class OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL;
    }
    public class OpSubgroupAvcMceSetInterShapePenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceSetInterShapePenaltyINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL;
    }
    public class OpSubgroupAvcMceSetInterDirectionPenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL;
    }
    public class OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL;
    }
    public class OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL;
    }
    public class OpSubgroupAvcMceSetAcOnlyHaarINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceSetAcOnlyHaarINTEL;
    }
    public class OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL;
    }
    public class OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL;
    }
    public class OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL;
    }
    public class OpSubgroupAvcMceConvertToImePayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceConvertToImePayloadINTEL;
    }
    public class OpSubgroupAvcMceConvertToImeResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceConvertToImeResultINTEL;
    }
    public class OpSubgroupAvcMceConvertToRefPayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceConvertToRefPayloadINTEL;
    }
    public class OpSubgroupAvcMceConvertToRefResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceConvertToRefResultINTEL;
    }
    public class OpSubgroupAvcMceConvertToSicPayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceConvertToSicPayloadINTEL;
    }
    public class OpSubgroupAvcMceConvertToSicResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceConvertToSicResultINTEL;
    }
    public class OpSubgroupAvcMceGetMotionVectorsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetMotionVectorsINTEL;
    }
    public class OpSubgroupAvcMceGetInterDistortionsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetInterDistortionsINTEL;
    }
    public class OpSubgroupAvcMceGetBestInterDistortionsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetBestInterDistortionsINTEL;
    }
    public class OpSubgroupAvcMceGetInterMajorShapeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetInterMajorShapeINTEL;
    }
    public class OpSubgroupAvcMceGetInterMinorShapeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetInterMinorShapeINTEL;
    }
    public class OpSubgroupAvcMceGetInterDirectionsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetInterDirectionsINTEL;
    }
    public class OpSubgroupAvcMceGetInterMotionVectorCountINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetInterMotionVectorCountINTEL;
    }
    public class OpSubgroupAvcMceGetInterReferenceIdsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetInterReferenceIdsINTEL;
    }
    public class OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL;
    }
    public class OpSubgroupAvcImeInitializeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeInitializeINTEL;
    }
    public class OpSubgroupAvcImeSetSingleReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeSetSingleReferenceINTEL;
    }
    public class OpSubgroupAvcImeSetDualReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeSetDualReferenceINTEL;
    }
    public class OpSubgroupAvcImeRefWindowSizeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeRefWindowSizeINTEL;
    }
    public class OpSubgroupAvcImeAdjustRefOffsetINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeAdjustRefOffsetINTEL;
    }
    public class OpSubgroupAvcImeConvertToMcePayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeConvertToMcePayloadINTEL;
    }
    public class OpSubgroupAvcImeSetMaxMotionVectorCountINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL;
    }
    public class OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL;
    }
    public class OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL;
    }
    public class OpSubgroupAvcImeSetWeightedSadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeSetWeightedSadINTEL;
    }
    public class OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL;
    }
    public class OpSubgroupAvcImeEvaluateWithDualReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL;
    }
    public class OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL;
    }
    public class OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL;
    }
    public class OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL;
    }
    public class OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL;
    }
    public class OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL;
    }
    public class OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL;
    }
    public class OpSubgroupAvcImeConvertToMceResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeConvertToMceResultINTEL;
    }
    public class OpSubgroupAvcImeGetSingleReferenceStreaminINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL;
    }
    public class OpSubgroupAvcImeGetDualReferenceStreaminINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetDualReferenceStreaminINTEL;
    }
    public class OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL;
    }
    public class OpSubgroupAvcImeStripDualReferenceStreamoutINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL;
    }
    public class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL;
    }
    public class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL;
    }
    public class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL;
    }
    public class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL;
    }
    public class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL;
    }
    public class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL;
    }
    public class OpSubgroupAvcImeGetBorderReachedINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetBorderReachedINTEL;
    }
    public class OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL;
    }
    public class OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL;
    }
    public class OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL;
    }
    public class OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL;
    }
    public class OpSubgroupAvcFmeInitializeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcFmeInitializeINTEL;
    }
    public class OpSubgroupAvcBmeInitializeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcBmeInitializeINTEL;
    }
    public class OpSubgroupAvcRefConvertToMcePayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcRefConvertToMcePayloadINTEL;
    }
    public class OpSubgroupAvcRefSetBidirectionalMixDisableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL;
    }
    public class OpSubgroupAvcRefSetBilinearFilterEnableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcRefSetBilinearFilterEnableINTEL;
    }
    public class OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL;
    }
    public class OpSubgroupAvcRefEvaluateWithDualReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL;
    }
    public class OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL;
    }
    public class OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL;
    }
    public class OpSubgroupAvcRefConvertToMceResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcRefConvertToMceResultINTEL;
    }
    public class OpSubgroupAvcSicInitializeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicInitializeINTEL;
    }
    public class OpSubgroupAvcSicConfigureSkcINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicConfigureSkcINTEL;
    }
    public class OpSubgroupAvcSicConfigureIpeLumaINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicConfigureIpeLumaINTEL;
    }
    public class OpSubgroupAvcSicConfigureIpeLumaChromaINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL;
    }
    public class OpSubgroupAvcSicGetMotionVectorMaskINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetMotionVectorMaskINTEL;
    }
    public class OpSubgroupAvcSicConvertToMcePayloadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicConvertToMcePayloadINTEL;
    }
    public class OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL;
    }
    public class OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL;
    }
    public class OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL;
    }
    public class OpSubgroupAvcSicSetBilinearFilterEnableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicSetBilinearFilterEnableINTEL;
    }
    public class OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL;
    }
    public class OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL;
    }
    public class OpSubgroupAvcSicEvaluateIpeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicEvaluateIpeINTEL;
    }
    public class OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL;
    }
    public class OpSubgroupAvcSicEvaluateWithDualReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL;
    }
    public class OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL;
    }
    public class OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL;
    }
    public class OpSubgroupAvcSicConvertToMceResultINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicConvertToMceResultINTEL;
    }
    public class OpSubgroupAvcSicGetIpeLumaShapeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetIpeLumaShapeINTEL;
    }
    public class OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL;
    }
    public class OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL;
    }
    public class OpSubgroupAvcSicGetPackedIpeLumaModesINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL;
    }
    public class OpSubgroupAvcSicGetIpeChromaModeINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetIpeChromaModeINTEL;
    }
    public class OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL;
    }
    public class OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL;
    }
    public class OpSubgroupAvcSicGetInterRawSadsINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpSubgroupAvcSicGetInterRawSadsINTEL;
    }
    public class OpLoopControlINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpLoopControlINTEL;
    }
    public class OpReadPipeBlockingINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpReadPipeBlockingINTEL;
    }
    public class OpWritePipeBlockingINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpWritePipeBlockingINTEL;
    }
    public class OpFPGARegINTEL : IInstruction
    {
        public OpCode Opcode => OpCode.OpFPGARegINTEL;
    }
    public class OpRayQueryGetRayTMinKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetRayTMinKHR;
    }
    public class OpRayQueryGetRayFlagsKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetRayFlagsKHR;
    }
    public class OpRayQueryGetIntersectionTKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionTKHR;
    }
    public class OpRayQueryGetIntersectionInstanceCustomIndexKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionInstanceCustomIndexKHR;
    }
    public class OpRayQueryGetIntersectionInstanceIdKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionInstanceIdKHR;
    }
    public class OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR;
    }
    public class OpRayQueryGetIntersectionGeometryIndexKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionGeometryIndexKHR;
    }
    public class OpRayQueryGetIntersectionPrimitiveIndexKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionPrimitiveIndexKHR;
    }
    public class OpRayQueryGetIntersectionBarycentricsKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionBarycentricsKHR;
    }
    public class OpRayQueryGetIntersectionFrontFaceKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionFrontFaceKHR;
    }
    public class OpRayQueryGetIntersectionCandidateAABBOpaqueKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR;
    }
    public class OpRayQueryGetIntersectionObjectRayDirectionKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionObjectRayDirectionKHR;
    }
    public class OpRayQueryGetIntersectionObjectRayOriginKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionObjectRayOriginKHR;
    }
    public class OpRayQueryGetWorldRayDirectionKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetWorldRayDirectionKHR;
    }
    public class OpRayQueryGetWorldRayOriginKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetWorldRayOriginKHR;
    }
    public class OpRayQueryGetIntersectionObjectToWorldKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionObjectToWorldKHR;
    }
    public class OpRayQueryGetIntersectionWorldToObjectKHR : IInstruction
    {
        public OpCode Opcode => OpCode.OpRayQueryGetIntersectionWorldToObjectKHR;
    }
    public class OpAtomicFAddEXT : IInstruction
    {
        public OpCode Opcode => OpCode.OpAtomicFAddEXT;
    }
}
