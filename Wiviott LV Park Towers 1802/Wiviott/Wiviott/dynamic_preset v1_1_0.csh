[BEGIN]
  Version=1
[END]
[BEGIN]
  ObjTp=FSgntr
  Sgntr=CresSPlus
  RelVrs=1
  IntStrVrs=1
  SPlusVrs=4.02.26
  CrossCplrVrs=1.3
[END]
[BEGIN]
  ObjTp=Hd
  Cmn1=This module is designed for use with projects created using D3 Pro||1
  Cmn2=v1.1 or later. It\\allows lighting levels to be stored to and recalled||1
  Cmn3=from disk. Data is stored in a\\binary file that may reside on Compact||1
  Cmn4=Flash or on the NVRAM Disk.\\\\REVISION HISTORY\\================\\
  Cmn5=\\v1.1.0\\------\\-no longer validate the path$ string when it changes.
  Cmn6=||1This was causing a problem on systems with a\\ very large number||1
  Cmn7=of learnable presets. Instead, we will assume that this path is||1
  Cmn8=valid, and\\ a separate SIMPL+ module will be responsible for creating||1
  Cmn9=the directory if it does not exist.\\\\v1.0.2\\------\\-copy input||1
  Cmn10=levels to output levels on "save". This is need to resync "Scene"||1
  Cmn11=feedback after\\ saving new levels to disk.\\\\v1.0.1\\------\\-
  Cmn12=removed error message on startup stating that NVRAM was not a valid||1
  Cmn13=directory\\\\v1.0\\----\\-initial public release\\
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,167,168,179,213,214,215,216,217,225,226,248,249,266,267,310,718,756,854,
  Exclusions_CDS=5
  Inclusions_CDS=6
  Name=Dynamic Presets v1.1.0 (cm)
  SmplCName=dynamic_preset v1_1_0.csp
  Code=1
  SysRev5=3.154
  SMWRev=3.00.00
  InputCue1=recall
  InputSigType1=Digital
  InputCue2=save
  InputSigType2=Digital
  InputCue3=delete
  InputSigType3=Digital
  OutputCue1=recall_ok
  OutputSigType1=Digital
  OutputCue2=recall_error
  OutputSigType2=Digital
  OutputCue3=save_ok
  OutputSigType3=Digital
  OutputCue4=save_error
  OutputSigType4=Digital
  OutputCue5=delete_ok
  OutputSigType5=Digital
  OutputCue6=delete_error
  OutputSigType6=Digital
  InputList2Cue1=path$
  InputList2SigType1=Serial
  InputList2Cue2=filename$
  InputList2SigType2=Serial
  InputList2Cue3=level_in[#]
  InputList2SigType3=Analog
  OutputList2Cue1=level_out[#]
  OutputList2SigType1=Analog
  ParamCue1=[Reference Name]
  MinVariableInputs=3
  MaxVariableInputs=3
  MinVariableInputsList2=3
  MaxVariableInputsList2=202
  MinVariableOutputs=6
  MaxVariableOutputs=6
  MinVariableOutputsList2=1
  MaxVariableOutputsList2=200
  MinVariableParams=0
  MaxVariableParams=0
  Expand=expand_separately
  Expand2=expand_separately
  ProgramTree=Logic
  SymbolTree=0
  Hint=
  PdfHelp=
  HelpID= 
  Render=4
  Smpl-C=16
  CompilerCode=-48
  CompilerParamCode=27
  CompilerParamCode5=14
  NumFixedParams=1
  Pp1=1
  MPp=1
  NVStorage=10
  ParamSigType1=String
  SmplCInputCue1=o#
  SmplCOutputCue1=i#
  SmplCInputList2Cue1=an#
  SmplCOutputList2Cue1=ai#
  SPlus2CompiledName=S2_dynamic_preset_v1_1_0
  SymJam=NonExclusive
  FileName=dynamic_preset v1_1_0.csh
  SIMPLPlusModuleEncoding=0
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]
