namespace SpirVNET.Instructions
{
    public interface IInstruction
    {
        int OpCode { get; }
    }
    public class OpNop : IInstruction
    {
        public int OpCode => 0;
    }
    public class OpUndef : IInstruction
    {
        public int OpCode => 1;
    }
    public class OpSourceContinued : IInstruction
    {
        public int OpCode => 2;
    }
    public class OpSource : IInstruction
    {
        public int OpCode => 3;
    }
    public class OpSourceExtension : IInstruction
    {
        public int OpCode => 4;
    }
    public class OpName : IInstruction
    {
        public int OpCode => 5;
    }
    public class OpMemberName : IInstruction
    {
        public int OpCode => 6;
    }
    public class OpString : IInstruction
    {
        public int OpCode => 7;
    }
    public class OpLine : IInstruction
    {
        public int OpCode => 8;
    }
    public class OpExtension : IInstruction
    {
        public int OpCode => 10;
    }
    public class OpExtInstImport : IInstruction
    {
        public int OpCode => 11;
    }
    public class OpExtInst : IInstruction
    {
        public int OpCode => 12;
    }
    public class OpMemoryModel : IInstruction
    {
        public int OpCode => 14;
    }
    public class OpEntryPoint : IInstruction
    {
        public int OpCode => 15;
    }
    public class OpExecutionMode : IInstruction
    {
        public int OpCode => 16;
    }
    public class OpCapability : IInstruction
    {
        public int OpCode => 17;
    }
    public class OpTypeVoid : IInstruction
    {
        public int OpCode => 19;
    }
    public class OpTypeBool : IInstruction
    {
        public int OpCode => 20;
    }
    public class OpTypeInt : IInstruction
    {
        public int OpCode => 21;
    }
    public class OpTypeFloat : IInstruction
    {
        public int OpCode => 22;
    }
    public class OpTypeVector : IInstruction
    {
        public int OpCode => 23;
    }
    public class OpTypeMatrix : IInstruction
    {
        public int OpCode => 24;
    }
    public class OpTypeImage : IInstruction
    {
        public int OpCode => 25;
    }
    public class OpTypeSampler : IInstruction
    {
        public int OpCode => 26;
    }
    public class OpTypeSampledImage : IInstruction
    {
        public int OpCode => 27;
    }
    public class OpTypeArray : IInstruction
    {
        public int OpCode => 28;
    }
    public class OpTypeRuntimeArray : IInstruction
    {
        public int OpCode => 29;
    }
    public class OpTypeStruct : IInstruction
    {
        public int OpCode => 30;
    }
    public class OpTypeOpaque : IInstruction
    {
        public int OpCode => 31;
    }
    public class OpTypePointer : IInstruction
    {
        public int OpCode => 32;
    }
    public class OpTypeFunction : IInstruction
    {
        public int OpCode => 33;
    }
    public class OpTypeEvent : IInstruction
    {
        public int OpCode => 34;
    }
    public class OpTypeDeviceEvent : IInstruction
    {
        public int OpCode => 35;
    }
    public class OpTypeReserveId : IInstruction
    {
        public int OpCode => 36;
    }
    public class OpTypeQueue : IInstruction
    {
        public int OpCode => 37;
    }
    public class OpTypePipe : IInstruction
    {
        public int OpCode => 38;
    }
    public class OpTypeForwardPointer : IInstruction
    {
        public int OpCode => 39;
    }
    public class OpConstantTrue : IInstruction
    {
        public int OpCode => 41;
    }
    public class OpConstantFalse : IInstruction
    {
        public int OpCode => 42;
    }
    public class OpConstant : IInstruction
    {
        public int OpCode => 43;
    }
    public class OpConstantComposite : IInstruction
    {
        public int OpCode => 44;
    }
    public class OpConstantSampler : IInstruction
    {
        public int OpCode => 45;
    }
    public class OpConstantNull : IInstruction
    {
        public int OpCode => 46;
    }
    public class OpSpecConstantTrue : IInstruction
    {
        public int OpCode => 48;
    }
    public class OpSpecConstantFalse : IInstruction
    {
        public int OpCode => 49;
    }
    public class OpSpecConstant : IInstruction
    {
        public int OpCode => 50;
    }
    public class OpSpecConstantComposite : IInstruction
    {
        public int OpCode => 51;
    }
    public class OpSpecConstantOp : IInstruction
    {
        public int OpCode => 52;
    }
    public class OpFunction : IInstruction
    {
        public int OpCode => 54;
    }
    public class OpFunctionParameter : IInstruction
    {
        public int OpCode => 55;
    }
    public class OpFunctionEnd : IInstruction
    {
        public int OpCode => 56;
    }
    public class OpFunctionCall : IInstruction
    {
        public int OpCode => 57;
    }
    public class OpVariable : IInstruction
    {
        public int OpCode => 59;
    }
    public class OpImageTexelPointer : IInstruction
    {
        public int OpCode => 60;
    }
    public class OpLoad : IInstruction
    {
        public int OpCode => 61;
    }
    public class OpStore : IInstruction
    {
        public int OpCode => 62;
    }
    public class OpCopyMemory : IInstruction
    {
        public int OpCode => 63;
    }
    public class OpCopyMemorySized : IInstruction
    {
        public int OpCode => 64;
    }
    public class OpAccessChain : IInstruction
    {
        public int OpCode => 65;
    }
    public class OpInBoundsAccessChain : IInstruction
    {
        public int OpCode => 66;
    }
    public class OpPtrAccessChain : IInstruction
    {
        public int OpCode => 67;
    }
    public class OpArrayLength : IInstruction
    {
        public int OpCode => 68;
    }
    public class OpGenericPtrMemSemantics : IInstruction
    {
        public int OpCode => 69;
    }
    public class OpInBoundsPtrAccessChain : IInstruction
    {
        public int OpCode => 70;
    }
    public class OpDecorate : IInstruction
    {
        public int OpCode => 71;
    }
    public class OpMemberDecorate : IInstruction
    {
        public int OpCode => 72;
    }
    public class OpDecorationGroup : IInstruction
    {
        public int OpCode => 73;
    }
    public class OpGroupDecorate : IInstruction
    {
        public int OpCode => 74;
    }
    public class OpGroupMemberDecorate : IInstruction
    {
        public int OpCode => 75;
    }
    public class OpVectorExtractDynamic : IInstruction
    {
        public int OpCode => 77;
    }
    public class OpVectorInsertDynamic : IInstruction
    {
        public int OpCode => 78;
    }
    public class OpVectorShuffle : IInstruction
    {
        public int OpCode => 79;
    }
    public class OpCompositeConstruct : IInstruction
    {
        public int OpCode => 80;
    }
    public class OpCompositeExtract : IInstruction
    {
        public int OpCode => 81;
    }
    public class OpCompositeInsert : IInstruction
    {
        public int OpCode => 82;
    }
    public class OpCopyObject : IInstruction
    {
        public int OpCode => 83;
    }
    public class OpTranspose : IInstruction
    {
        public int OpCode => 84;
    }
    public class OpSampledImage : IInstruction
    {
        public int OpCode => 86;
    }
    public class OpImageSampleImplicitLod : IInstruction
    {
        public int OpCode => 87;
    }
    public class OpImageSampleExplicitLod : IInstruction
    {
        public int OpCode => 88;
    }
    public class OpImageSampleDrefImplicitLod : IInstruction
    {
        public int OpCode => 89;
    }
    public class OpImageSampleDrefExplicitLod : IInstruction
    {
        public int OpCode => 90;
    }
    public class OpImageSampleProjImplicitLod : IInstruction
    {
        public int OpCode => 91;
    }
    public class OpImageSampleProjExplicitLod : IInstruction
    {
        public int OpCode => 92;
    }
    public class OpImageSampleProjDrefImplicitLod : IInstruction
    {
        public int OpCode => 93;
    }
    public class OpImageSampleProjDrefExplicitLod : IInstruction
    {
        public int OpCode => 94;
    }
    public class OpImageFetch : IInstruction
    {
        public int OpCode => 95;
    }
    public class OpImageGather : IInstruction
    {
        public int OpCode => 96;
    }
    public class OpImageDrefGather : IInstruction
    {
        public int OpCode => 97;
    }
    public class OpImageRead : IInstruction
    {
        public int OpCode => 98;
    }
    public class OpImageWrite : IInstruction
    {
        public int OpCode => 99;
    }
    public class OpImage : IInstruction
    {
        public int OpCode => 100;
    }
    public class OpImageQueryFormat : IInstruction
    {
        public int OpCode => 101;
    }
    public class OpImageQueryOrder : IInstruction
    {
        public int OpCode => 102;
    }
    public class OpImageQuerySizeLod : IInstruction
    {
        public int OpCode => 103;
    }
    public class OpImageQuerySize : IInstruction
    {
        public int OpCode => 104;
    }
    public class OpImageQueryLod : IInstruction
    {
        public int OpCode => 105;
    }
    public class OpImageQueryLevels : IInstruction
    {
        public int OpCode => 106;
    }
    public class OpImageQuerySamples : IInstruction
    {
        public int OpCode => 107;
    }
    public class OpConvertFToU : IInstruction
    {
        public int OpCode => 109;
    }
    public class OpConvertFToS : IInstruction
    {
        public int OpCode => 110;
    }
    public class OpConvertSToF : IInstruction
    {
        public int OpCode => 111;
    }
    public class OpConvertUToF : IInstruction
    {
        public int OpCode => 112;
    }
    public class OpUConvert : IInstruction
    {
        public int OpCode => 113;
    }
    public class OpSConvert : IInstruction
    {
        public int OpCode => 114;
    }
    public class OpFConvert : IInstruction
    {
        public int OpCode => 115;
    }
    public class OpQuantizeToF16 : IInstruction
    {
        public int OpCode => 116;
    }
    public class OpConvertPtrToU : IInstruction
    {
        public int OpCode => 117;
    }
    public class OpSatConvertSToU : IInstruction
    {
        public int OpCode => 118;
    }
    public class OpSatConvertUToS : IInstruction
    {
        public int OpCode => 119;
    }
    public class OpConvertUToPtr : IInstruction
    {
        public int OpCode => 120;
    }
    public class OpPtrCastToGeneric : IInstruction
    {
        public int OpCode => 121;
    }
    public class OpGenericCastToPtr : IInstruction
    {
        public int OpCode => 122;
    }
    public class OpGenericCastToPtrExplicit : IInstruction
    {
        public int OpCode => 123;
    }
    public class OpBitcast : IInstruction
    {
        public int OpCode => 124;
    }
    public class OpSNegate : IInstruction
    {
        public int OpCode => 126;
    }
    public class OpFNegate : IInstruction
    {
        public int OpCode => 127;
    }
    public class OpIAdd : IInstruction
    {
        public int OpCode => 128;
    }
    public class OpFAdd : IInstruction
    {
        public int OpCode => 129;
    }
    public class OpISub : IInstruction
    {
        public int OpCode => 130;
    }
    public class OpFSub : IInstruction
    {
        public int OpCode => 131;
    }
    public class OpIMul : IInstruction
    {
        public int OpCode => 132;
    }
    public class OpFMul : IInstruction
    {
        public int OpCode => 133;
    }
    public class OpUDiv : IInstruction
    {
        public int OpCode => 134;
    }
    public class OpSDiv : IInstruction
    {
        public int OpCode => 135;
    }
    public class OpFDiv : IInstruction
    {
        public int OpCode => 136;
    }
    public class OpUMod : IInstruction
    {
        public int OpCode => 137;
    }
    public class OpSRem : IInstruction
    {
        public int OpCode => 138;
    }
    public class OpSMod : IInstruction
    {
        public int OpCode => 139;
    }
    public class OpFRem : IInstruction
    {
        public int OpCode => 140;
    }
    public class OpFMod : IInstruction
    {
        public int OpCode => 141;
    }
    public class OpVectorTimesScalar : IInstruction
    {
        public int OpCode => 142;
    }
    public class OpMatrixTimesScalar : IInstruction
    {
        public int OpCode => 143;
    }
    public class OpVectorTimesMatrix : IInstruction
    {
        public int OpCode => 144;
    }
    public class OpMatrixTimesVector : IInstruction
    {
        public int OpCode => 145;
    }
    public class OpMatrixTimesMatrix : IInstruction
    {
        public int OpCode => 146;
    }
    public class OpOuterProduct : IInstruction
    {
        public int OpCode => 147;
    }
    public class OpDot : IInstruction
    {
        public int OpCode => 148;
    }
    public class OpIAddCarry : IInstruction
    {
        public int OpCode => 149;
    }
    public class OpISubBorrow : IInstruction
    {
        public int OpCode => 150;
    }
    public class OpUMulExtended : IInstruction
    {
        public int OpCode => 151;
    }
    public class OpSMulExtended : IInstruction
    {
        public int OpCode => 152;
    }
    public class OpAny : IInstruction
    {
        public int OpCode => 154;
    }
    public class OpAll : IInstruction
    {
        public int OpCode => 155;
    }
    public class OpIsNan : IInstruction
    {
        public int OpCode => 156;
    }
    public class OpIsInf : IInstruction
    {
        public int OpCode => 157;
    }
    public class OpIsFinite : IInstruction
    {
        public int OpCode => 158;
    }
    public class OpIsNormal : IInstruction
    {
        public int OpCode => 159;
    }
    public class OpSignBitSet : IInstruction
    {
        public int OpCode => 160;
    }
    public class OpLessOrGreater : IInstruction
    {
        public int OpCode => 161;
    }
    public class OpOrdered : IInstruction
    {
        public int OpCode => 162;
    }
    public class OpUnordered : IInstruction
    {
        public int OpCode => 163;
    }
    public class OpLogicalEqual : IInstruction
    {
        public int OpCode => 164;
    }
    public class OpLogicalNotEqual : IInstruction
    {
        public int OpCode => 165;
    }
    public class OpLogicalOr : IInstruction
    {
        public int OpCode => 166;
    }
    public class OpLogicalAnd : IInstruction
    {
        public int OpCode => 167;
    }
    public class OpLogicalNot : IInstruction
    {
        public int OpCode => 168;
    }
    public class OpSelect : IInstruction
    {
        public int OpCode => 169;
    }
    public class OpIEqual : IInstruction
    {
        public int OpCode => 170;
    }
    public class OpINotEqual : IInstruction
    {
        public int OpCode => 171;
    }
    public class OpUGreaterThan : IInstruction
    {
        public int OpCode => 172;
    }
    public class OpSGreaterThan : IInstruction
    {
        public int OpCode => 173;
    }
    public class OpUGreaterThanEqual : IInstruction
    {
        public int OpCode => 174;
    }
    public class OpSGreaterThanEqual : IInstruction
    {
        public int OpCode => 175;
    }
    public class OpULessThan : IInstruction
    {
        public int OpCode => 176;
    }
    public class OpSLessThan : IInstruction
    {
        public int OpCode => 177;
    }
    public class OpULessThanEqual : IInstruction
    {
        public int OpCode => 178;
    }
    public class OpSLessThanEqual : IInstruction
    {
        public int OpCode => 179;
    }
    public class OpFOrdEqual : IInstruction
    {
        public int OpCode => 180;
    }
    public class OpFUnordEqual : IInstruction
    {
        public int OpCode => 181;
    }
    public class OpFOrdNotEqual : IInstruction
    {
        public int OpCode => 182;
    }
    public class OpFUnordNotEqual : IInstruction
    {
        public int OpCode => 183;
    }
    public class OpFOrdLessThan : IInstruction
    {
        public int OpCode => 184;
    }
    public class OpFUnordLessThan : IInstruction
    {
        public int OpCode => 185;
    }
    public class OpFOrdGreaterThan : IInstruction
    {
        public int OpCode => 186;
    }
    public class OpFUnordGreaterThan : IInstruction
    {
        public int OpCode => 187;
    }
    public class OpFOrdLessThanEqual : IInstruction
    {
        public int OpCode => 188;
    }
    public class OpFUnordLessThanEqual : IInstruction
    {
        public int OpCode => 189;
    }
    public class OpFOrdGreaterThanEqual : IInstruction
    {
        public int OpCode => 190;
    }
    public class OpFUnordGreaterThanEqual : IInstruction
    {
        public int OpCode => 191;
    }
    public class OpShiftRightLogical : IInstruction
    {
        public int OpCode => 194;
    }
    public class OpShiftRightArithmetic : IInstruction
    {
        public int OpCode => 195;
    }
    public class OpShiftLeftLogical : IInstruction
    {
        public int OpCode => 196;
    }
    public class OpBitwiseOr : IInstruction
    {
        public int OpCode => 197;
    }
    public class OpBitwiseXor : IInstruction
    {
        public int OpCode => 198;
    }
    public class OpBitwiseAnd : IInstruction
    {
        public int OpCode => 199;
    }
    public class OpNot : IInstruction
    {
        public int OpCode => 200;
    }
    public class OpBitFieldInsert : IInstruction
    {
        public int OpCode => 201;
    }
    public class OpBitFieldSExtract : IInstruction
    {
        public int OpCode => 202;
    }
    public class OpBitFieldUExtract : IInstruction
    {
        public int OpCode => 203;
    }
    public class OpBitReverse : IInstruction
    {
        public int OpCode => 204;
    }
    public class OpBitCount : IInstruction
    {
        public int OpCode => 205;
    }
    public class OpDPdx : IInstruction
    {
        public int OpCode => 207;
    }
    public class OpDPdy : IInstruction
    {
        public int OpCode => 208;
    }
    public class OpFwidth : IInstruction
    {
        public int OpCode => 209;
    }
    public class OpDPdxFine : IInstruction
    {
        public int OpCode => 210;
    }
    public class OpDPdyFine : IInstruction
    {
        public int OpCode => 211;
    }
    public class OpFwidthFine : IInstruction
    {
        public int OpCode => 212;
    }
    public class OpDPdxCoarse : IInstruction
    {
        public int OpCode => 213;
    }
    public class OpDPdyCoarse : IInstruction
    {
        public int OpCode => 214;
    }
    public class OpFwidthCoarse : IInstruction
    {
        public int OpCode => 215;
    }
    public class OpEmitVertex : IInstruction
    {
        public int OpCode => 218;
    }
    public class OpEndPrimitive : IInstruction
    {
        public int OpCode => 219;
    }
    public class OpEmitStreamVertex : IInstruction
    {
        public int OpCode => 220;
    }
    public class OpEndStreamPrimitive : IInstruction
    {
        public int OpCode => 221;
    }
    public class OpControlBarrier : IInstruction
    {
        public int OpCode => 224;
    }
    public class OpMemoryBarrier : IInstruction
    {
        public int OpCode => 225;
    }
    public class OpAtomicLoad : IInstruction
    {
        public int OpCode => 227;
    }
    public class OpAtomicStore : IInstruction
    {
        public int OpCode => 228;
    }
    public class OpAtomicExchange : IInstruction
    {
        public int OpCode => 229;
    }
    public class OpAtomicCompareExchange : IInstruction
    {
        public int OpCode => 230;
    }
    public class OpAtomicCompareExchangeWeak : IInstruction
    {
        public int OpCode => 231;
    }
    public class OpAtomicIIncrement : IInstruction
    {
        public int OpCode => 232;
    }
    public class OpAtomicIDecrement : IInstruction
    {
        public int OpCode => 233;
    }
    public class OpAtomicIAdd : IInstruction
    {
        public int OpCode => 234;
    }
    public class OpAtomicISub : IInstruction
    {
        public int OpCode => 235;
    }
    public class OpAtomicSMin : IInstruction
    {
        public int OpCode => 236;
    }
    public class OpAtomicUMin : IInstruction
    {
        public int OpCode => 237;
    }
    public class OpAtomicSMax : IInstruction
    {
        public int OpCode => 238;
    }
    public class OpAtomicUMax : IInstruction
    {
        public int OpCode => 239;
    }
    public class OpAtomicAnd : IInstruction
    {
        public int OpCode => 240;
    }
    public class OpAtomicOr : IInstruction
    {
        public int OpCode => 241;
    }
    public class OpAtomicXor : IInstruction
    {
        public int OpCode => 242;
    }
    public class OpPhi : IInstruction
    {
        public int OpCode => 245;
    }
    public class OpLoopMerge : IInstruction
    {
        public int OpCode => 246;
    }
    public class OpSelectionMerge : IInstruction
    {
        public int OpCode => 247;
    }
    public class OpLabel : IInstruction
    {
        public int OpCode => 248;
    }
    public class OpBranch : IInstruction
    {
        public int OpCode => 249;
    }
    public class OpBranchConditional : IInstruction
    {
        public int OpCode => 250;
    }
    public class OpSwitch : IInstruction
    {
        public int OpCode => 251;
    }
    public class OpKill : IInstruction
    {
        public int OpCode => 252;
    }
    public class OpReturn : IInstruction
    {
        public int OpCode => 253;
    }
    public class OpReturnValue : IInstruction
    {
        public int OpCode => 254;
    }
    public class OpUnreachable : IInstruction
    {
        public int OpCode => 255;
    }
    public class OpLifetimeStart : IInstruction
    {
        public int OpCode => 256;
    }
    public class OpLifetimeStop : IInstruction
    {
        public int OpCode => 257;
    }
    public class OpGroupAsyncCopy : IInstruction
    {
        public int OpCode => 259;
    }
    public class OpGroupWaitEvents : IInstruction
    {
        public int OpCode => 260;
    }
    public class OpGroupAll : IInstruction
    {
        public int OpCode => 261;
    }
    public class OpGroupAny : IInstruction
    {
        public int OpCode => 262;
    }
    public class OpGroupBroadcast : IInstruction
    {
        public int OpCode => 263;
    }
    public class OpGroupIAdd : IInstruction
    {
        public int OpCode => 264;
    }
    public class OpGroupFAdd : IInstruction
    {
        public int OpCode => 265;
    }
    public class OpGroupFMin : IInstruction
    {
        public int OpCode => 266;
    }
    public class OpGroupUMin : IInstruction
    {
        public int OpCode => 267;
    }
    public class OpGroupSMin : IInstruction
    {
        public int OpCode => 268;
    }
    public class OpGroupFMax : IInstruction
    {
        public int OpCode => 269;
    }
    public class OpGroupUMax : IInstruction
    {
        public int OpCode => 270;
    }
    public class OpGroupSMax : IInstruction
    {
        public int OpCode => 271;
    }
    public class OpReadPipe : IInstruction
    {
        public int OpCode => 274;
    }
    public class OpWritePipe : IInstruction
    {
        public int OpCode => 275;
    }
    public class OpReservedReadPipe : IInstruction
    {
        public int OpCode => 276;
    }
    public class OpReservedWritePipe : IInstruction
    {
        public int OpCode => 277;
    }
    public class OpReserveReadPipePackets : IInstruction
    {
        public int OpCode => 278;
    }
    public class OpReserveWritePipePackets : IInstruction
    {
        public int OpCode => 279;
    }
    public class OpCommitReadPipe : IInstruction
    {
        public int OpCode => 280;
    }
    public class OpCommitWritePipe : IInstruction
    {
        public int OpCode => 281;
    }
    public class OpIsValidReserveId : IInstruction
    {
        public int OpCode => 282;
    }
    public class OpGetNumPipePackets : IInstruction
    {
        public int OpCode => 283;
    }
    public class OpGetMaxPipePackets : IInstruction
    {
        public int OpCode => 284;
    }
    public class OpGroupReserveReadPipePackets : IInstruction
    {
        public int OpCode => 285;
    }
    public class OpGroupReserveWritePipePackets : IInstruction
    {
        public int OpCode => 286;
    }
    public class OpGroupCommitReadPipe : IInstruction
    {
        public int OpCode => 287;
    }
    public class OpGroupCommitWritePipe : IInstruction
    {
        public int OpCode => 288;
    }
    public class OpEnqueueMarker : IInstruction
    {
        public int OpCode => 291;
    }
    public class OpEnqueueKernel : IInstruction
    {
        public int OpCode => 292;
    }
    public class OpGetKernelNDrangeSubGroupCount : IInstruction
    {
        public int OpCode => 293;
    }
    public class OpGetKernelNDrangeMaxSubGroupSize : IInstruction
    {
        public int OpCode => 294;
    }
    public class OpGetKernelWorkGroupSize : IInstruction
    {
        public int OpCode => 295;
    }
    public class OpGetKernelPreferredWorkGroupSizeMultiple : IInstruction
    {
        public int OpCode => 296;
    }
    public class OpRetainEvent : IInstruction
    {
        public int OpCode => 297;
    }
    public class OpReleaseEvent : IInstruction
    {
        public int OpCode => 298;
    }
    public class OpCreateUserEvent : IInstruction
    {
        public int OpCode => 299;
    }
    public class OpIsValidEvent : IInstruction
    {
        public int OpCode => 300;
    }
    public class OpSetUserEventStatus : IInstruction
    {
        public int OpCode => 301;
    }
    public class OpCaptureEventProfilingInfo : IInstruction
    {
        public int OpCode => 302;
    }
    public class OpGetDefaultQueue : IInstruction
    {
        public int OpCode => 303;
    }
    public class OpBuildNDRange : IInstruction
    {
        public int OpCode => 304;
    }
    public class OpImageSparseSampleImplicitLod : IInstruction
    {
        public int OpCode => 305;
    }
    public class OpImageSparseSampleExplicitLod : IInstruction
    {
        public int OpCode => 306;
    }
    public class OpImageSparseSampleDrefImplicitLod : IInstruction
    {
        public int OpCode => 307;
    }
    public class OpImageSparseSampleDrefExplicitLod : IInstruction
    {
        public int OpCode => 308;
    }
    public class OpImageSparseSampleProjImplicitLod : IInstruction
    {
        public int OpCode => 309;
    }
    public class OpImageSparseSampleProjExplicitLod : IInstruction
    {
        public int OpCode => 310;
    }
    public class OpImageSparseSampleProjDrefImplicitLod : IInstruction
    {
        public int OpCode => 311;
    }
    public class OpImageSparseSampleProjDrefExplicitLod : IInstruction
    {
        public int OpCode => 312;
    }
    public class OpImageSparseFetch : IInstruction
    {
        public int OpCode => 313;
    }
    public class OpImageSparseGather : IInstruction
    {
        public int OpCode => 314;
    }
    public class OpImageSparseDrefGather : IInstruction
    {
        public int OpCode => 315;
    }
    public class OpImageSparseTexelsResident : IInstruction
    {
        public int OpCode => 316;
    }
    public class OpNoLine : IInstruction
    {
        public int OpCode => 317;
    }
    public class OpAtomicFlagTestAndSet : IInstruction
    {
        public int OpCode => 318;
    }
    public class OpAtomicFlagClear : IInstruction
    {
        public int OpCode => 319;
    }
    public class OpImageSparseRead : IInstruction
    {
        public int OpCode => 320;
    }
    public class OpSizeOf : IInstruction
    {
        public int OpCode => 321;
    }
    public class OpTypePipeStorage : IInstruction
    {
        public int OpCode => 322;
    }
    public class OpConstantPipeStorage : IInstruction
    {
        public int OpCode => 323;
    }
    public class OpCreatePipeFromPipeStorage : IInstruction
    {
        public int OpCode => 324;
    }
    public class OpGetKernelLocalSizeForSubgroupCount : IInstruction
    {
        public int OpCode => 325;
    }
    public class OpGetKernelMaxNumSubgroups : IInstruction
    {
        public int OpCode => 326;
    }
    public class OpTypeNamedBarrier : IInstruction
    {
        public int OpCode => 327;
    }
    public class OpNamedBarrierInitialize : IInstruction
    {
        public int OpCode => 328;
    }
    public class OpMemoryNamedBarrier : IInstruction
    {
        public int OpCode => 329;
    }
    public class OpModuleProcessed : IInstruction
    {
        public int OpCode => 330;
    }
    public class OpExecutionModeId : IInstruction
    {
        public int OpCode => 331;
    }
    public class OpDecorateId : IInstruction
    {
        public int OpCode => 332;
    }
    public class OpGroupNonUniformElect : IInstruction
    {
        public int OpCode => 333;
    }
    public class OpGroupNonUniformAll : IInstruction
    {
        public int OpCode => 334;
    }
    public class OpGroupNonUniformAny : IInstruction
    {
        public int OpCode => 335;
    }
    public class OpGroupNonUniformAllEqual : IInstruction
    {
        public int OpCode => 336;
    }
    public class OpGroupNonUniformBroadcast : IInstruction
    {
        public int OpCode => 337;
    }
    public class OpGroupNonUniformBroadcastFirst : IInstruction
    {
        public int OpCode => 338;
    }
    public class OpGroupNonUniformBallot : IInstruction
    {
        public int OpCode => 339;
    }
    public class OpGroupNonUniformInverseBallot : IInstruction
    {
        public int OpCode => 340;
    }
    public class OpGroupNonUniformBallotBitExtract : IInstruction
    {
        public int OpCode => 341;
    }
    public class OpGroupNonUniformBallotBitCount : IInstruction
    {
        public int OpCode => 342;
    }
    public class OpGroupNonUniformBallotFindLSB : IInstruction
    {
        public int OpCode => 343;
    }
    public class OpGroupNonUniformBallotFindMSB : IInstruction
    {
        public int OpCode => 344;
    }
    public class OpGroupNonUniformShuffle : IInstruction
    {
        public int OpCode => 345;
    }
    public class OpGroupNonUniformShuffleXor : IInstruction
    {
        public int OpCode => 346;
    }
    public class OpGroupNonUniformShuffleUp : IInstruction
    {
        public int OpCode => 347;
    }
    public class OpGroupNonUniformShuffleDown : IInstruction
    {
        public int OpCode => 348;
    }
    public class OpGroupNonUniformIAdd : IInstruction
    {
        public int OpCode => 349;
    }
    public class OpGroupNonUniformFAdd : IInstruction
    {
        public int OpCode => 350;
    }
    public class OpGroupNonUniformIMul : IInstruction
    {
        public int OpCode => 351;
    }
    public class OpGroupNonUniformFMul : IInstruction
    {
        public int OpCode => 352;
    }
    public class OpGroupNonUniformSMin : IInstruction
    {
        public int OpCode => 353;
    }
    public class OpGroupNonUniformUMin : IInstruction
    {
        public int OpCode => 354;
    }
    public class OpGroupNonUniformFMin : IInstruction
    {
        public int OpCode => 355;
    }
    public class OpGroupNonUniformSMax : IInstruction
    {
        public int OpCode => 356;
    }
    public class OpGroupNonUniformUMax : IInstruction
    {
        public int OpCode => 357;
    }
    public class OpGroupNonUniformFMax : IInstruction
    {
        public int OpCode => 358;
    }
    public class OpGroupNonUniformBitwiseAnd : IInstruction
    {
        public int OpCode => 359;
    }
    public class OpGroupNonUniformBitwiseOr : IInstruction
    {
        public int OpCode => 360;
    }
    public class OpGroupNonUniformBitwiseXor : IInstruction
    {
        public int OpCode => 361;
    }
    public class OpGroupNonUniformLogicalAnd : IInstruction
    {
        public int OpCode => 362;
    }
    public class OpGroupNonUniformLogicalOr : IInstruction
    {
        public int OpCode => 363;
    }
    public class OpGroupNonUniformLogicalXor : IInstruction
    {
        public int OpCode => 364;
    }
    public class OpGroupNonUniformQuadBroadcast : IInstruction
    {
        public int OpCode => 365;
    }
    public class OpGroupNonUniformQuadSwap : IInstruction
    {
        public int OpCode => 366;
    }
    public class OpCopyLogical : IInstruction
    {
        public int OpCode => 400;
    }
    public class OpPtrEqual : IInstruction
    {
        public int OpCode => 401;
    }
    public class OpPtrNotEqual : IInstruction
    {
        public int OpCode => 402;
    }
    public class OpPtrDiff : IInstruction
    {
        public int OpCode => 403;
    }
    public class OpTerminateInvocation : IInstruction
    {
        public int OpCode => 4416;
    }
    public class OpSubgroupBallotKHR : IInstruction
    {
        public int OpCode => 4421;
    }
    public class OpSubgroupFirstInvocationKHR : IInstruction
    {
        public int OpCode => 4422;
    }
    public class OpSubgroupAllKHR : IInstruction
    {
        public int OpCode => 4428;
    }
    public class OpSubgroupAnyKHR : IInstruction
    {
        public int OpCode => 4429;
    }
    public class OpSubgroupAllEqualKHR : IInstruction
    {
        public int OpCode => 4430;
    }
    public class OpSubgroupReadInvocationKHR : IInstruction
    {
        public int OpCode => 4432;
    }
    public class OpTypeRayQueryProvisionalKHR : IInstruction
    {
        public int OpCode => 4472;
    }
    public class OpRayQueryInitializeKHR : IInstruction
    {
        public int OpCode => 4473;
    }
    public class OpRayQueryTerminateKHR : IInstruction
    {
        public int OpCode => 4474;
    }
    public class OpRayQueryGenerateIntersectionKHR : IInstruction
    {
        public int OpCode => 4475;
    }
    public class OpRayQueryConfirmIntersectionKHR : IInstruction
    {
        public int OpCode => 4476;
    }
    public class OpRayQueryProceedKHR : IInstruction
    {
        public int OpCode => 4477;
    }
    public class OpRayQueryGetIntersectionTypeKHR : IInstruction
    {
        public int OpCode => 4479;
    }
    public class OpGroupIAddNonUniformAMD : IInstruction
    {
        public int OpCode => 5000;
    }
    public class OpGroupFAddNonUniformAMD : IInstruction
    {
        public int OpCode => 5001;
    }
    public class OpGroupFMinNonUniformAMD : IInstruction
    {
        public int OpCode => 5002;
    }
    public class OpGroupUMinNonUniformAMD : IInstruction
    {
        public int OpCode => 5003;
    }
    public class OpGroupSMinNonUniformAMD : IInstruction
    {
        public int OpCode => 5004;
    }
    public class OpGroupFMaxNonUniformAMD : IInstruction
    {
        public int OpCode => 5005;
    }
    public class OpGroupUMaxNonUniformAMD : IInstruction
    {
        public int OpCode => 5006;
    }
    public class OpGroupSMaxNonUniformAMD : IInstruction
    {
        public int OpCode => 5007;
    }
    public class OpFragmentMaskFetchAMD : IInstruction
    {
        public int OpCode => 5011;
    }
    public class OpFragmentFetchAMD : IInstruction
    {
        public int OpCode => 5012;
    }
    public class OpReadClockKHR : IInstruction
    {
        public int OpCode => 5056;
    }
    public class OpImageSampleFootprintNV : IInstruction
    {
        public int OpCode => 5283;
    }
    public class OpGroupNonUniformPartitionNV : IInstruction
    {
        public int OpCode => 5296;
    }
    public class OpWritePackedPrimitiveIndices4x8NV : IInstruction
    {
        public int OpCode => 5299;
    }
    public class OpReportIntersectionNV : IInstruction
    {
        public int OpCode => 5334;
    }
    public class OpReportIntersectionKHR : IInstruction
    {
        public int OpCode => 5334;
    }
    public class OpIgnoreIntersectionNV : IInstruction
    {
        public int OpCode => 5335;
    }
    public class OpIgnoreIntersectionKHR : IInstruction
    {
        public int OpCode => 5335;
    }
    public class OpTerminateRayNV : IInstruction
    {
        public int OpCode => 5336;
    }
    public class OpTerminateRayKHR : IInstruction
    {
        public int OpCode => 5336;
    }
    public class OpTraceNV : IInstruction
    {
        public int OpCode => 5337;
    }
    public class OpTraceRayKHR : IInstruction
    {
        public int OpCode => 5337;
    }
    public class OpTypeAccelerationStructureNV : IInstruction
    {
        public int OpCode => 5341;
    }
    public class OpTypeAccelerationStructureKHR : IInstruction
    {
        public int OpCode => 5341;
    }
    public class OpExecuteCallableNV : IInstruction
    {
        public int OpCode => 5344;
    }
    public class OpExecuteCallableKHR : IInstruction
    {
        public int OpCode => 5344;
    }
    public class OpTypeCooperativeMatrixNV : IInstruction
    {
        public int OpCode => 5358;
    }
    public class OpCooperativeMatrixLoadNV : IInstruction
    {
        public int OpCode => 5359;
    }
    public class OpCooperativeMatrixStoreNV : IInstruction
    {
        public int OpCode => 5360;
    }
    public class OpCooperativeMatrixMulAddNV : IInstruction
    {
        public int OpCode => 5361;
    }
    public class OpCooperativeMatrixLengthNV : IInstruction
    {
        public int OpCode => 5362;
    }
    public class OpBeginInvocationInterlockEXT : IInstruction
    {
        public int OpCode => 5364;
    }
    public class OpEndInvocationInterlockEXT : IInstruction
    {
        public int OpCode => 5365;
    }
    public class OpDemoteToHelperInvocationEXT : IInstruction
    {
        public int OpCode => 5380;
    }
    public class OpIsHelperInvocationEXT : IInstruction
    {
        public int OpCode => 5381;
    }
    public class OpSubgroupShuffleINTEL : IInstruction
    {
        public int OpCode => 5571;
    }
    public class OpSubgroupShuffleDownINTEL : IInstruction
    {
        public int OpCode => 5572;
    }
    public class OpSubgroupShuffleUpINTEL : IInstruction
    {
        public int OpCode => 5573;
    }
    public class OpSubgroupShuffleXorINTEL : IInstruction
    {
        public int OpCode => 5574;
    }
    public class OpSubgroupBlockReadINTEL : IInstruction
    {
        public int OpCode => 5575;
    }
    public class OpSubgroupBlockWriteINTEL : IInstruction
    {
        public int OpCode => 5576;
    }
    public class OpSubgroupImageBlockReadINTEL : IInstruction
    {
        public int OpCode => 5577;
    }
    public class OpSubgroupImageBlockWriteINTEL : IInstruction
    {
        public int OpCode => 5578;
    }
    public class OpSubgroupImageMediaBlockReadINTEL : IInstruction
    {
        public int OpCode => 5580;
    }
    public class OpSubgroupImageMediaBlockWriteINTEL : IInstruction
    {
        public int OpCode => 5581;
    }
    public class OpUCountLeadingZerosINTEL : IInstruction
    {
        public int OpCode => 5585;
    }
    public class OpUCountTrailingZerosINTEL : IInstruction
    {
        public int OpCode => 5586;
    }
    public class OpAbsISubINTEL : IInstruction
    {
        public int OpCode => 5587;
    }
    public class OpAbsUSubINTEL : IInstruction
    {
        public int OpCode => 5588;
    }
    public class OpIAddSatINTEL : IInstruction
    {
        public int OpCode => 5589;
    }
    public class OpUAddSatINTEL : IInstruction
    {
        public int OpCode => 5590;
    }
    public class OpIAverageINTEL : IInstruction
    {
        public int OpCode => 5591;
    }
    public class OpUAverageINTEL : IInstruction
    {
        public int OpCode => 5592;
    }
    public class OpIAverageRoundedINTEL : IInstruction
    {
        public int OpCode => 5593;
    }
    public class OpUAverageRoundedINTEL : IInstruction
    {
        public int OpCode => 5594;
    }
    public class OpISubSatINTEL : IInstruction
    {
        public int OpCode => 5595;
    }
    public class OpUSubSatINTEL : IInstruction
    {
        public int OpCode => 5596;
    }
    public class OpIMul32x16INTEL : IInstruction
    {
        public int OpCode => 5597;
    }
    public class OpUMul32x16INTEL : IInstruction
    {
        public int OpCode => 5598;
    }
    public class OpFunctionPointerINTEL : IInstruction
    {
        public int OpCode => 5600;
    }
    public class OpFunctionPointerCallINTEL : IInstruction
    {
        public int OpCode => 5601;
    }
    public class OpDecorateString : IInstruction
    {
        public int OpCode => 5632;
    }
    public class OpDecorateStringGOOGLE : IInstruction
    {
        public int OpCode => 5632;
    }
    public class OpMemberDecorateString : IInstruction
    {
        public int OpCode => 5633;
    }
    public class OpMemberDecorateStringGOOGLE : IInstruction
    {
        public int OpCode => 5633;
    }
    public class OpVmeImageINTEL : IInstruction
    {
        public int OpCode => 5699;
    }
    public class OpTypeVmeImageINTEL : IInstruction
    {
        public int OpCode => 5700;
    }
    public class OpTypeAvcImePayloadINTEL : IInstruction
    {
        public int OpCode => 5701;
    }
    public class OpTypeAvcRefPayloadINTEL : IInstruction
    {
        public int OpCode => 5702;
    }
    public class OpTypeAvcSicPayloadINTEL : IInstruction
    {
        public int OpCode => 5703;
    }
    public class OpTypeAvcMcePayloadINTEL : IInstruction
    {
        public int OpCode => 5704;
    }
    public class OpTypeAvcMceResultINTEL : IInstruction
    {
        public int OpCode => 5705;
    }
    public class OpTypeAvcImeResultINTEL : IInstruction
    {
        public int OpCode => 5706;
    }
    public class OpTypeAvcImeResultSingleReferenceStreamoutINTEL : IInstruction
    {
        public int OpCode => 5707;
    }
    public class OpTypeAvcImeResultDualReferenceStreamoutINTEL : IInstruction
    {
        public int OpCode => 5708;
    }
    public class OpTypeAvcImeSingleReferenceStreaminINTEL : IInstruction
    {
        public int OpCode => 5709;
    }
    public class OpTypeAvcImeDualReferenceStreaminINTEL : IInstruction
    {
        public int OpCode => 5710;
    }
    public class OpTypeAvcRefResultINTEL : IInstruction
    {
        public int OpCode => 5711;
    }
    public class OpTypeAvcSicResultINTEL : IInstruction
    {
        public int OpCode => 5712;
    }
    public class OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL : IInstruction
    {
        public int OpCode => 5713;
    }
    public class OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL : IInstruction
    {
        public int OpCode => 5714;
    }
    public class OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL : IInstruction
    {
        public int OpCode => 5715;
    }
    public class OpSubgroupAvcMceSetInterShapePenaltyINTEL : IInstruction
    {
        public int OpCode => 5716;
    }
    public class OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL : IInstruction
    {
        public int OpCode => 5717;
    }
    public class OpSubgroupAvcMceSetInterDirectionPenaltyINTEL : IInstruction
    {
        public int OpCode => 5718;
    }
    public class OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL : IInstruction
    {
        public int OpCode => 5719;
    }
    public class OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL : IInstruction
    {
        public int OpCode => 5720;
    }
    public class OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL : IInstruction
    {
        public int OpCode => 5721;
    }
    public class OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL : IInstruction
    {
        public int OpCode => 5722;
    }
    public class OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL : IInstruction
    {
        public int OpCode => 5723;
    }
    public class OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL : IInstruction
    {
        public int OpCode => 5724;
    }
    public class OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL : IInstruction
    {
        public int OpCode => 5725;
    }
    public class OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL : IInstruction
    {
        public int OpCode => 5726;
    }
    public class OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL : IInstruction
    {
        public int OpCode => 5727;
    }
    public class OpSubgroupAvcMceSetAcOnlyHaarINTEL : IInstruction
    {
        public int OpCode => 5728;
    }
    public class OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL : IInstruction
    {
        public int OpCode => 5729;
    }
    public class OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL : IInstruction
    {
        public int OpCode => 5730;
    }
    public class OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL : IInstruction
    {
        public int OpCode => 5731;
    }
    public class OpSubgroupAvcMceConvertToImePayloadINTEL : IInstruction
    {
        public int OpCode => 5732;
    }
    public class OpSubgroupAvcMceConvertToImeResultINTEL : IInstruction
    {
        public int OpCode => 5733;
    }
    public class OpSubgroupAvcMceConvertToRefPayloadINTEL : IInstruction
    {
        public int OpCode => 5734;
    }
    public class OpSubgroupAvcMceConvertToRefResultINTEL : IInstruction
    {
        public int OpCode => 5735;
    }
    public class OpSubgroupAvcMceConvertToSicPayloadINTEL : IInstruction
    {
        public int OpCode => 5736;
    }
    public class OpSubgroupAvcMceConvertToSicResultINTEL : IInstruction
    {
        public int OpCode => 5737;
    }
    public class OpSubgroupAvcMceGetMotionVectorsINTEL : IInstruction
    {
        public int OpCode => 5738;
    }
    public class OpSubgroupAvcMceGetInterDistortionsINTEL : IInstruction
    {
        public int OpCode => 5739;
    }
    public class OpSubgroupAvcMceGetBestInterDistortionsINTEL : IInstruction
    {
        public int OpCode => 5740;
    }
    public class OpSubgroupAvcMceGetInterMajorShapeINTEL : IInstruction
    {
        public int OpCode => 5741;
    }
    public class OpSubgroupAvcMceGetInterMinorShapeINTEL : IInstruction
    {
        public int OpCode => 5742;
    }
    public class OpSubgroupAvcMceGetInterDirectionsINTEL : IInstruction
    {
        public int OpCode => 5743;
    }
    public class OpSubgroupAvcMceGetInterMotionVectorCountINTEL : IInstruction
    {
        public int OpCode => 5744;
    }
    public class OpSubgroupAvcMceGetInterReferenceIdsINTEL : IInstruction
    {
        public int OpCode => 5745;
    }
    public class OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL : IInstruction
    {
        public int OpCode => 5746;
    }
    public class OpSubgroupAvcImeInitializeINTEL : IInstruction
    {
        public int OpCode => 5747;
    }
    public class OpSubgroupAvcImeSetSingleReferenceINTEL : IInstruction
    {
        public int OpCode => 5748;
    }
    public class OpSubgroupAvcImeSetDualReferenceINTEL : IInstruction
    {
        public int OpCode => 5749;
    }
    public class OpSubgroupAvcImeRefWindowSizeINTEL : IInstruction
    {
        public int OpCode => 5750;
    }
    public class OpSubgroupAvcImeAdjustRefOffsetINTEL : IInstruction
    {
        public int OpCode => 5751;
    }
    public class OpSubgroupAvcImeConvertToMcePayloadINTEL : IInstruction
    {
        public int OpCode => 5752;
    }
    public class OpSubgroupAvcImeSetMaxMotionVectorCountINTEL : IInstruction
    {
        public int OpCode => 5753;
    }
    public class OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL : IInstruction
    {
        public int OpCode => 5754;
    }
    public class OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL : IInstruction
    {
        public int OpCode => 5755;
    }
    public class OpSubgroupAvcImeSetWeightedSadINTEL : IInstruction
    {
        public int OpCode => 5756;
    }
    public class OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL : IInstruction
    {
        public int OpCode => 5757;
    }
    public class OpSubgroupAvcImeEvaluateWithDualReferenceINTEL : IInstruction
    {
        public int OpCode => 5758;
    }
    public class OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL : IInstruction
    {
        public int OpCode => 5759;
    }
    public class OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL : IInstruction
    {
        public int OpCode => 5760;
    }
    public class OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL : IInstruction
    {
        public int OpCode => 5761;
    }
    public class OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL : IInstruction
    {
        public int OpCode => 5762;
    }
    public class OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL : IInstruction
    {
        public int OpCode => 5763;
    }
    public class OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL : IInstruction
    {
        public int OpCode => 5764;
    }
    public class OpSubgroupAvcImeConvertToMceResultINTEL : IInstruction
    {
        public int OpCode => 5765;
    }
    public class OpSubgroupAvcImeGetSingleReferenceStreaminINTEL : IInstruction
    {
        public int OpCode => 5766;
    }
    public class OpSubgroupAvcImeGetDualReferenceStreaminINTEL : IInstruction
    {
        public int OpCode => 5767;
    }
    public class OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL : IInstruction
    {
        public int OpCode => 5768;
    }
    public class OpSubgroupAvcImeStripDualReferenceStreamoutINTEL : IInstruction
    {
        public int OpCode => 5769;
    }
    public class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL : IInstruction
    {
        public int OpCode => 5770;
    }
    public class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL : IInstruction
    {
        public int OpCode => 5771;
    }
    public class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL : IInstruction
    {
        public int OpCode => 5772;
    }
    public class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL : IInstruction
    {
        public int OpCode => 5773;
    }
    public class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL : IInstruction
    {
        public int OpCode => 5774;
    }
    public class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL : IInstruction
    {
        public int OpCode => 5775;
    }
    public class OpSubgroupAvcImeGetBorderReachedINTEL : IInstruction
    {
        public int OpCode => 5776;
    }
    public class OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL : IInstruction
    {
        public int OpCode => 5777;
    }
    public class OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL : IInstruction
    {
        public int OpCode => 5778;
    }
    public class OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL : IInstruction
    {
        public int OpCode => 5779;
    }
    public class OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL : IInstruction
    {
        public int OpCode => 5780;
    }
    public class OpSubgroupAvcFmeInitializeINTEL : IInstruction
    {
        public int OpCode => 5781;
    }
    public class OpSubgroupAvcBmeInitializeINTEL : IInstruction
    {
        public int OpCode => 5782;
    }
    public class OpSubgroupAvcRefConvertToMcePayloadINTEL : IInstruction
    {
        public int OpCode => 5783;
    }
    public class OpSubgroupAvcRefSetBidirectionalMixDisableINTEL : IInstruction
    {
        public int OpCode => 5784;
    }
    public class OpSubgroupAvcRefSetBilinearFilterEnableINTEL : IInstruction
    {
        public int OpCode => 5785;
    }
    public class OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL : IInstruction
    {
        public int OpCode => 5786;
    }
    public class OpSubgroupAvcRefEvaluateWithDualReferenceINTEL : IInstruction
    {
        public int OpCode => 5787;
    }
    public class OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL : IInstruction
    {
        public int OpCode => 5788;
    }
    public class OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL : IInstruction
    {
        public int OpCode => 5789;
    }
    public class OpSubgroupAvcRefConvertToMceResultINTEL : IInstruction
    {
        public int OpCode => 5790;
    }
    public class OpSubgroupAvcSicInitializeINTEL : IInstruction
    {
        public int OpCode => 5791;
    }
    public class OpSubgroupAvcSicConfigureSkcINTEL : IInstruction
    {
        public int OpCode => 5792;
    }
    public class OpSubgroupAvcSicConfigureIpeLumaINTEL : IInstruction
    {
        public int OpCode => 5793;
    }
    public class OpSubgroupAvcSicConfigureIpeLumaChromaINTEL : IInstruction
    {
        public int OpCode => 5794;
    }
    public class OpSubgroupAvcSicGetMotionVectorMaskINTEL : IInstruction
    {
        public int OpCode => 5795;
    }
    public class OpSubgroupAvcSicConvertToMcePayloadINTEL : IInstruction
    {
        public int OpCode => 5796;
    }
    public class OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL : IInstruction
    {
        public int OpCode => 5797;
    }
    public class OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL : IInstruction
    {
        public int OpCode => 5798;
    }
    public class OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL : IInstruction
    {
        public int OpCode => 5799;
    }
    public class OpSubgroupAvcSicSetBilinearFilterEnableINTEL : IInstruction
    {
        public int OpCode => 5800;
    }
    public class OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL : IInstruction
    {
        public int OpCode => 5801;
    }
    public class OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL : IInstruction
    {
        public int OpCode => 5802;
    }
    public class OpSubgroupAvcSicEvaluateIpeINTEL : IInstruction
    {
        public int OpCode => 5803;
    }
    public class OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL : IInstruction
    {
        public int OpCode => 5804;
    }
    public class OpSubgroupAvcSicEvaluateWithDualReferenceINTEL : IInstruction
    {
        public int OpCode => 5805;
    }
    public class OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL : IInstruction
    {
        public int OpCode => 5806;
    }
    public class OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL : IInstruction
    {
        public int OpCode => 5807;
    }
    public class OpSubgroupAvcSicConvertToMceResultINTEL : IInstruction
    {
        public int OpCode => 5808;
    }
    public class OpSubgroupAvcSicGetIpeLumaShapeINTEL : IInstruction
    {
        public int OpCode => 5809;
    }
    public class OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL : IInstruction
    {
        public int OpCode => 5810;
    }
    public class OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL : IInstruction
    {
        public int OpCode => 5811;
    }
    public class OpSubgroupAvcSicGetPackedIpeLumaModesINTEL : IInstruction
    {
        public int OpCode => 5812;
    }
    public class OpSubgroupAvcSicGetIpeChromaModeINTEL : IInstruction
    {
        public int OpCode => 5813;
    }
    public class OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL : IInstruction
    {
        public int OpCode => 5814;
    }
    public class OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL : IInstruction
    {
        public int OpCode => 5815;
    }
    public class OpSubgroupAvcSicGetInterRawSadsINTEL : IInstruction
    {
        public int OpCode => 5816;
    }
    public class OpLoopControlINTEL : IInstruction
    {
        public int OpCode => 5887;
    }
    public class OpReadPipeBlockingINTEL : IInstruction
    {
        public int OpCode => 5946;
    }
    public class OpWritePipeBlockingINTEL : IInstruction
    {
        public int OpCode => 5947;
    }
    public class OpFPGARegINTEL : IInstruction
    {
        public int OpCode => 5949;
    }
    public class OpRayQueryGetRayTMinKHR : IInstruction
    {
        public int OpCode => 6016;
    }
    public class OpRayQueryGetRayFlagsKHR : IInstruction
    {
        public int OpCode => 6017;
    }
    public class OpRayQueryGetIntersectionTKHR : IInstruction
    {
        public int OpCode => 6018;
    }
    public class OpRayQueryGetIntersectionInstanceCustomIndexKHR : IInstruction
    {
        public int OpCode => 6019;
    }
    public class OpRayQueryGetIntersectionInstanceIdKHR : IInstruction
    {
        public int OpCode => 6020;
    }
    public class OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR : IInstruction
    {
        public int OpCode => 6021;
    }
    public class OpRayQueryGetIntersectionGeometryIndexKHR : IInstruction
    {
        public int OpCode => 6022;
    }
    public class OpRayQueryGetIntersectionPrimitiveIndexKHR : IInstruction
    {
        public int OpCode => 6023;
    }
    public class OpRayQueryGetIntersectionBarycentricsKHR : IInstruction
    {
        public int OpCode => 6024;
    }
    public class OpRayQueryGetIntersectionFrontFaceKHR : IInstruction
    {
        public int OpCode => 6025;
    }
    public class OpRayQueryGetIntersectionCandidateAABBOpaqueKHR : IInstruction
    {
        public int OpCode => 6026;
    }
    public class OpRayQueryGetIntersectionObjectRayDirectionKHR : IInstruction
    {
        public int OpCode => 6027;
    }
    public class OpRayQueryGetIntersectionObjectRayOriginKHR : IInstruction
    {
        public int OpCode => 6028;
    }
    public class OpRayQueryGetWorldRayDirectionKHR : IInstruction
    {
        public int OpCode => 6029;
    }
    public class OpRayQueryGetWorldRayOriginKHR : IInstruction
    {
        public int OpCode => 6030;
    }
    public class OpRayQueryGetIntersectionObjectToWorldKHR : IInstruction
    {
        public int OpCode => 6031;
    }
    public class OpRayQueryGetIntersectionWorldToObjectKHR : IInstruction
    {
        public int OpCode => 6032;
    }
    public class OpAtomicFAddEXT : IInstruction
    {
        public int OpCode => 6035;
    }
}
