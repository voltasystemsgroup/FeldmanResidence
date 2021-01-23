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
  Cmn1=This module is similar to the 'Message To Computer Port' symbol,||1
  Cmn2=except that it takes\\a serial signal as its input. Each time the||1
  Cmn3=input signal 'message$' changes, its\\value will be output to the||1
  Cmn4=console. Each string that is sent out will have a newline\\character||1
  Cmn5=appended to it automatically.\\\\The digital inputs 'timestamp'||1
  Cmn6=and 'datestamp' should be set to a logical high (1)\\if you want||1
  Cmn7=the message to have the current time and/or date appended to it.
  Cmn8=||1If both\\inputs are set low, the message will print to the console||1
  Cmn9=exactly as it came in\\(plus the newline character).\\\\You can||1
  Cmn10=use the Serial I/O symbol to generate the message$ input from a||1
  Cmn11=series of\\digital signals.||1
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,310,718,756,854,
  Exclusions_CDS=5
  Inclusions_CDS=6
  Name=Dynamic Message To Computer Port (cm)
  SmplCName=tmsg2.csp
  Code=1
  SysRev5=3.154
  SMWRev=3.00.00
  InputCue1=timestamp
  InputSigType1=Digital
  InputCue2=datestamp
  InputSigType2=Digital
  InputList2Cue1=message$
  InputList2SigType1=Serial
  ParamCue1=[Reference Name]
  MinVariableInputs=2
  MaxVariableInputs=2
  MinVariableInputsList2=1
  MaxVariableInputsList2=1
  MinVariableOutputs=0
  MaxVariableOutputs=0
  MinVariableOutputsList2=0
  MaxVariableOutputsList2=0
  MinVariableParams=0
  MaxVariableParams=0
  Expand=expand_separately
  Expand2=expand_separately
  ProgramTree=Logic
  SymbolTree=3
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
  SPlus2CompiledName=S2_tmsg2
  SymJam=NonExclusive
  FileName=tmsg2.csh
  SIMPLPlusModuleEncoding=0
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]
