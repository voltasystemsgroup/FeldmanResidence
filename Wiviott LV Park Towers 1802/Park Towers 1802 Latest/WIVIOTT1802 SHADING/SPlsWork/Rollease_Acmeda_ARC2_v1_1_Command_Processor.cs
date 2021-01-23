using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using CCI_Library;
using CCI_Library.Network;
using CCI_Library.Debugger;
using CCI_Library.WebScripting;
using RolleaseAcmedaARCv2;

namespace UserModule_ROLLEASE_ACMEDA_ARC2_V1_1_COMMAND_PROCESSOR
{
    public class UserModuleClass_ROLLEASE_ACMEDA_ARC2_V1_1_COMMAND_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CONNECT;
        Crestron.Logos.SplusObjects.DigitalInput DISCONNECT;
        Crestron.Logos.SplusObjects.DigitalInput REINITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_SETUP;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_PASSBACK;
        Crestron.Logos.SplusObjects.StringInput PASSTHROUGH;
        Crestron.Logos.SplusObjects.DigitalOutput IS_COMMUNICATING;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.StringOutput MOTOR_ADDRESS;
        Crestron.Logos.SplusObjects.StringOutput PASSBACK;
        Crestron.Logos.SplusObjects.StringOutput HUB_NAME;
        Crestron.Logos.SplusObjects.StringOutput HUB_MAC;
        UShortParameter COMMAND_PROCESSOR_ID;
        StringParameter PULSE_HUB_IP_ADDRESS;
        RolleaseAcmedaARCv2.Rollease DEVICE;
        CrestronString MOTORADDRESS;
        CrestronString HUBNAME;
        CrestronString HUBMAC;
        private void RESETALLINFO (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 114;
            IS_COMMUNICATING  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 115;
            IS_INITIALIZED  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 118;
            MOTORADDRESS  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 119;
            HUBNAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 120;
            HUBMAC  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 122;
            MOTOR_ADDRESS  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 123;
            PASSBACK  .UpdateValue ( ""  ) ; 
            
            }
            
        public void ONDEBUGCHANGE ( object __sender__ /*RolleaseAcmedaARCv2.Rollease SENDER */, RolleaseAcmedaARCv2.StringEventArgs ARGS ) 
            { 
            Rollease  SENDER  = (Rollease )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 132;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER.GetProcessorID() == COMMAND_PROCESSOR_ID  .Value))  ) ) 
                    {
                    __context__.SourceCodeLine = 133;
                    Trace( "{0}", ARGS . payload ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONCOMMUNICATINGCHANGE ( object __sender__ /*RolleaseAcmedaARCv2.Rollease SENDER */, RolleaseAcmedaARCv2.IntegerEventArgs ARGS ) 
            { 
            Rollease  SENDER  = (Rollease )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 138;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER.GetProcessorID() == COMMAND_PROCESSOR_ID  .Value))  ) ) 
                    {
                    __context__.SourceCodeLine = 139;
                    IS_COMMUNICATING  .Value = (ushort) ( ARGS.payload ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONINITIALIZEDCHANGE ( object __sender__ /*RolleaseAcmedaARCv2.Rollease SENDER */, RolleaseAcmedaARCv2.IntegerEventArgs ARGS ) 
            { 
            Rollease  SENDER  = (Rollease )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 144;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER.GetProcessorID() == COMMAND_PROCESSOR_ID  .Value))  ) ) 
                    {
                    __context__.SourceCodeLine = 145;
                    IS_INITIALIZED  .Value = (ushort) ( ARGS.payload ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONMOTORADDRESSCHANGE ( object __sender__ /*RolleaseAcmedaARCv2.Rollease SENDER */, RolleaseAcmedaARCv2.StringEventArgs ARGS ) 
            { 
            Rollease  SENDER  = (Rollease )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 150;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER.GetProcessorID() == COMMAND_PROCESSOR_ID  .Value))  ) ) 
                    { 
                    __context__.SourceCodeLine = 152;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOTORADDRESS != ARGS.payload))  ) ) 
                        { 
                        __context__.SourceCodeLine = 154;
                        MOTORADDRESS  .UpdateValue ( ARGS . payload  ) ; 
                        __context__.SourceCodeLine = 155;
                        MakeString ( MOTOR_ADDRESS , "{0}", ARGS . payload ) ; 
                        } 
                    
                    } 
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONPASSBACKCHANGE ( object __sender__ /*RolleaseAcmedaARCv2.Rollease SENDER */, RolleaseAcmedaARCv2.StringEventArgs ARGS ) 
            { 
            Rollease  SENDER  = (Rollease )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 162;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER.GetProcessorID() == COMMAND_PROCESSOR_ID  .Value))  ) ) 
                    {
                    __context__.SourceCodeLine = 163;
                    MakeString ( PASSBACK , "{0}", ARGS . payload ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONHUBNAMECHANGE ( object __sender__ /*RolleaseAcmedaARCv2.Rollease SENDER */, RolleaseAcmedaARCv2.StringEventArgs ARGS ) 
            { 
            Rollease  SENDER  = (Rollease )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 168;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER.GetProcessorID() == COMMAND_PROCESSOR_ID  .Value))  ) ) 
                    { 
                    __context__.SourceCodeLine = 170;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HUBNAME != ARGS.payload))  ) ) 
                        { 
                        __context__.SourceCodeLine = 172;
                        HUBNAME  .UpdateValue ( ARGS . payload  ) ; 
                        __context__.SourceCodeLine = 173;
                        MakeString ( HUB_NAME , "{0}", ARGS . payload ) ; 
                        } 
                    
                    } 
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONHUBMACCHANGE ( object __sender__ /*RolleaseAcmedaARCv2.Rollease SENDER */, RolleaseAcmedaARCv2.StringEventArgs ARGS ) 
            { 
            Rollease  SENDER  = (Rollease )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 180;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER.GetProcessorID() == COMMAND_PROCESSOR_ID  .Value))  ) ) 
                    { 
                    __context__.SourceCodeLine = 182;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HUBMAC != ARGS.payload))  ) ) 
                        { 
                        __context__.SourceCodeLine = 184;
                        HUBMAC  .UpdateValue ( ARGS . payload  ) ; 
                        __context__.SourceCodeLine = 185;
                        MakeString ( HUB_MAC , "{0}", ARGS . payload ) ; 
                        } 
                    
                    } 
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object CONNECT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 196;
                DEVICE . Connect ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DISCONNECT_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 201;
            DEVICE . Disconnect ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object REINITIALIZE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 206;
        DEVICE . Reinitialize ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_DEBUG_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 211;
        DEVICE . SetDebug ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_DEBUG_OnRelease_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 216;
        DEVICE . SetDebug ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_SETUP_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 221;
        DEVICE . SetSetup ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_SETUP_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 226;
        DEVICE . SetSetup ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_PASSBACK_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 231;
        DEVICE . SetPassback ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_PASSBACK_OnRelease_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 236;
        DEVICE . SetPassback ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PASSTHROUGH_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 241;
        DEVICE . Passthrough ( PASSTHROUGH .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 250;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 251;
        RESETALLINFO (  __context__  ) ; 
        __context__.SourceCodeLine = 253;
        // RegisterEvent( DEVICE , ONDEBUGCHANGE , ONDEBUGCHANGE ) 
        try { g_criticalSection.Enter(); DEVICE .OnDebugChange  += ONDEBUGCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 254;
        // RegisterEvent( DEVICE , ONCOMMUNICATINGCHANGE , ONCOMMUNICATINGCHANGE ) 
        try { g_criticalSection.Enter(); DEVICE .OnCommunicatingChange  += ONCOMMUNICATINGCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 255;
        // RegisterEvent( DEVICE , ONINITIALIZEDCHANGE , ONINITIALIZEDCHANGE ) 
        try { g_criticalSection.Enter(); DEVICE .OnInitializedChange  += ONINITIALIZEDCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 256;
        // RegisterEvent( DEVICE , ONMOTORADDRESSCHANGE , ONMOTORADDRESSCHANGE ) 
        try { g_criticalSection.Enter(); DEVICE .OnMotorAddressChange  += ONMOTORADDRESSCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 257;
        // RegisterEvent( DEVICE , ONPASSBACKCHANGE , ONPASSBACKCHANGE ) 
        try { g_criticalSection.Enter(); DEVICE .OnPassbackChange  += ONPASSBACKCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 258;
        // RegisterEvent( DEVICE , ONHUBNAMECHANGE , ONHUBNAMECHANGE ) 
        try { g_criticalSection.Enter(); DEVICE .OnHubNameChange  += ONHUBNAMECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 259;
        // RegisterEvent( DEVICE , ONHUBMACCHANGE , ONHUBMACCHANGE ) 
        try { g_criticalSection.Enter(); DEVICE .OnHubMACChange  += ONHUBMACCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 261;
        Functions.Delay (  (int) ( 500 ) ) ; 
        __context__.SourceCodeLine = 263;
        DEVICE . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), PULSE_HUB_IP_ADDRESS  .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    MOTORADDRESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    HUBNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    HUBMAC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    CONNECT = new Crestron.Logos.SplusObjects.DigitalInput( CONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECT__DigitalInput__, CONNECT );
    
    DISCONNECT = new Crestron.Logos.SplusObjects.DigitalInput( DISCONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( DISCONNECT__DigitalInput__, DISCONNECT );
    
    REINITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( REINITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( REINITIALIZE__DigitalInput__, REINITIALIZE );
    
    ENABLE_DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_DEBUG__DigitalInput__, ENABLE_DEBUG );
    
    ENABLE_SETUP = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_SETUP__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_SETUP__DigitalInput__, ENABLE_SETUP );
    
    ENABLE_PASSBACK = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_PASSBACK__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_PASSBACK__DigitalInput__, ENABLE_PASSBACK );
    
    IS_COMMUNICATING = new Crestron.Logos.SplusObjects.DigitalOutput( IS_COMMUNICATING__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_COMMUNICATING__DigitalOutput__, IS_COMMUNICATING );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    PASSTHROUGH = new Crestron.Logos.SplusObjects.StringInput( PASSTHROUGH__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( PASSTHROUGH__AnalogSerialInput__, PASSTHROUGH );
    
    MOTOR_ADDRESS = new Crestron.Logos.SplusObjects.StringOutput( MOTOR_ADDRESS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MOTOR_ADDRESS__AnalogSerialOutput__, MOTOR_ADDRESS );
    
    PASSBACK = new Crestron.Logos.SplusObjects.StringOutput( PASSBACK__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PASSBACK__AnalogSerialOutput__, PASSBACK );
    
    HUB_NAME = new Crestron.Logos.SplusObjects.StringOutput( HUB_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( HUB_NAME__AnalogSerialOutput__, HUB_NAME );
    
    HUB_MAC = new Crestron.Logos.SplusObjects.StringOutput( HUB_MAC__AnalogSerialOutput__, this );
    m_StringOutputList.Add( HUB_MAC__AnalogSerialOutput__, HUB_MAC );
    
    COMMAND_PROCESSOR_ID = new UShortParameter( COMMAND_PROCESSOR_ID__Parameter__, this );
    m_ParameterList.Add( COMMAND_PROCESSOR_ID__Parameter__, COMMAND_PROCESSOR_ID );
    
    PULSE_HUB_IP_ADDRESS = new StringParameter( PULSE_HUB_IP_ADDRESS__Parameter__, this );
    m_ParameterList.Add( PULSE_HUB_IP_ADDRESS__Parameter__, PULSE_HUB_IP_ADDRESS );
    
    
    CONNECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONNECT_OnPush_0, true ) );
    DISCONNECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISCONNECT_OnPush_1, true ) );
    REINITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( REINITIALIZE_OnPush_2, true ) );
    ENABLE_DEBUG.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_DEBUG_OnPush_3, true ) );
    ENABLE_DEBUG.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_DEBUG_OnRelease_4, true ) );
    ENABLE_SETUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_SETUP_OnPush_5, true ) );
    ENABLE_SETUP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_SETUP_OnRelease_6, true ) );
    ENABLE_PASSBACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_PASSBACK_OnPush_7, true ) );
    ENABLE_PASSBACK.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_PASSBACK_OnRelease_8, true ) );
    PASSTHROUGH.OnSerialChange.Add( new InputChangeHandlerWrapper( PASSTHROUGH_OnChange_9, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    DEVICE  = new RolleaseAcmedaARCv2.Rollease();
    
    
}

public UserModuleClass_ROLLEASE_ACMEDA_ARC2_V1_1_COMMAND_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CONNECT__DigitalInput__ = 0;
const uint DISCONNECT__DigitalInput__ = 1;
const uint REINITIALIZE__DigitalInput__ = 2;
const uint ENABLE_DEBUG__DigitalInput__ = 3;
const uint ENABLE_SETUP__DigitalInput__ = 4;
const uint ENABLE_PASSBACK__DigitalInput__ = 5;
const uint PASSTHROUGH__AnalogSerialInput__ = 0;
const uint IS_COMMUNICATING__DigitalOutput__ = 0;
const uint IS_INITIALIZED__DigitalOutput__ = 1;
const uint MOTOR_ADDRESS__AnalogSerialOutput__ = 0;
const uint PASSBACK__AnalogSerialOutput__ = 1;
const uint HUB_NAME__AnalogSerialOutput__ = 2;
const uint HUB_MAC__AnalogSerialOutput__ = 3;
const uint COMMAND_PROCESSOR_ID__Parameter__ = 10;
const uint PULSE_HUB_IP_ADDRESS__Parameter__ = 11;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
