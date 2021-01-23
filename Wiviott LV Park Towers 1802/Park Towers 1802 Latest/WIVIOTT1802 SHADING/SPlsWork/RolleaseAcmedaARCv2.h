namespace RolleaseAcmedaARCv2;
        // class declarations
         class ComponentUtil;
         class TCPTransportComm;
         class Response;
         class ResponseMotorNotPresent;
         class StringEventArgs;
         class CommandBuilder;
         class ResponseHubMotorAddress;
         class ResponseParser;
         class Component;
         class MotorComponent;
         class Request;
         class ResponseMotorVoltage;
         class ResponseMotorNoBattery;
         class Protocol;
         class ResponseHubName;
         class ResponseHubMac;
         class ResponseMotorTypeVersion;
         class ResponseMotorName;
         class ResponseMotorRoom;
         class Rollease;
         class ResponseMotorPositionRotation;
         class MotorTypeMap;
         class ResponseCleaner;
         class IntegerEventArgs;
     class ComponentUtil 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION Register ( Component me );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class StringEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING payload[];
    };

     class CommandBuilder 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ResponseParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class Component 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Reset ();
        FUNCTION GetInitialized ();
        FUNCTION SendHeartbeat ();
        FUNCTION Poll ();
        FUNCTION ProcessResponse ( Request request , Response response );
        FUNCTION FailedResponse ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING address[];

        // class properties
        SIGNED_LONG_INTEGER id;
        INTEGER commandProcessor;
    };

     class MotorComponent 
    {
        // class delegates

        // class events
        EventHandler OnCommunicatingChange ( MotorComponent sender, IntegerEventArgs args );
        EventHandler OnInitializedChange ( MotorComponent sender, IntegerEventArgs args );
        EventHandler OnLastSetPositionChange ( MotorComponent sender, IntegerEventArgs args );
        EventHandler OnLastSetRotationChange ( MotorComponent sender, IntegerEventArgs args );
        EventHandler OnCurrentPositionChange ( MotorComponent sender, IntegerEventArgs args );
        EventHandler OnCurrentRotationChange ( MotorComponent sender, IntegerEventArgs args );
        EventHandler OnVersionChange ( MotorComponent sender, StringEventArgs args );
        EventHandler OnTypeChange ( MotorComponent sender, StringEventArgs args );
        EventHandler OnVoltageChange ( MotorComponent sender, StringEventArgs args );
        EventHandler OnNameChange ( MotorComponent sender, StringEventArgs args );
        EventHandler OnRoomChange ( MotorComponent sender, StringEventArgs args );

        // class functions
        INTEGER_FUNCTION GetProcessorID ();
        STRING_FUNCTION GetMotorAddress ();
        FUNCTION Configure ( INTEGER commandProcessor , STRING address );
        FUNCTION MoveUp ();
        FUNCTION MoveDown ();
        FUNCTION JogUp ();
        FUNCTION JogDown ();
        FUNCTION Stop ();
        FUNCTION SetPosition ();
        FUNCTION SetRotation ();
        FUNCTION SetPositionValue ( INTEGER value );
        FUNCTION SetRotationValue ( INTEGER value );
        FUNCTION SetForceInitialized ( INTEGER state );
        FUNCTION Reset ();
        FUNCTION SendHeartbeat ();
        FUNCTION Poll ();
        FUNCTION GetInitialized ();
        FUNCTION FailedResponse ();
        FUNCTION ProcessResponse ( Request request , Response response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING address[];

        // class properties
        SIGNED_LONG_INTEGER id;
        INTEGER commandProcessor;
    };

     class Protocol 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CMD_HEADER[];
        static STRING CMD_QUERY[];
        static STRING CMD_DELIM[];
        static STRING CMD_HUB_ADDRESS[];
        static STRING CMD_HUB_NAME[];
        static STRING CMD_HUB_MAC[];
        static STRING CMD_MOTOR_NAME[];
        static STRING CMD_MOTOR_ROOM[];
        static STRING CMD_MOTOR_TYPE_VERSION[];
        static STRING CMD_MOTOR_VOLTAGE[];
        static STRING CMD_MOTOR_POSITION[];
        static STRING CMD_MOTOR_ROTATION[];
        static STRING CMD_MOTOR_NO_BATTERY[];
        static STRING CMD_MOTOR_NOT_PRESENT_1[];
        static STRING CMD_MOTOR_NOT_PRESENT_2[];
        static STRING CMD_MOTOR_MOVE_UP[];
        static STRING CMD_MOTOR_MOVE_DOWN[];
        static STRING CMD_MOTOR_JOG_UP[];
        static STRING CMD_MOTOR_JOG_DOWN[];
        static STRING CMD_MOTOR_STOP[];
        static STRING CMD_MOTOR_MOVE_TO[];
        static STRING CMD_MOTOR_ROTATE_TO[];

        // class properties
    };

     class Rollease 
    {
        // class delegates

        // class events
        EventHandler OnDebugChange ( Rollease sender, StringEventArgs args );
        EventHandler OnCommunicatingChange ( Rollease sender, IntegerEventArgs args );
        EventHandler OnInitializedChange ( Rollease sender, IntegerEventArgs args );
        EventHandler OnMotorAddressChange ( Rollease sender, StringEventArgs args );
        EventHandler OnPassbackChange ( Rollease sender, StringEventArgs args );
        EventHandler OnHubNameChange ( Rollease sender, StringEventArgs args );
        EventHandler OnHubMACChange ( Rollease sender, StringEventArgs args );

        // class functions
        INTEGER_FUNCTION GetProcessorID ();
        FUNCTION Configure ( INTEGER commandProcessor , STRING ipAddress );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        FUNCTION Reinitialize ();
        FUNCTION SetDebug ( INTEGER state );
        FUNCTION SetSetup ( INTEGER state );
        FUNCTION SetPassback ( INTEGER state );
        FUNCTION Passthrough ( STRING msg );
        FUNCTION FailedResponse ();
        SIGNED_LONG_INTEGER_FUNCTION GetHeartbeatTime ();
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetResponseTime ();
        FUNCTION Reconnect ();
        FUNCTION SendHeartbeat ();
        FUNCTION Strikeout ();
        FUNCTION sendTrace ( STRING msg );
        FUNCTION ErrorChange ( STRING msg );
        FUNCTION Enqueue ( Request request );
        FUNCTION Debug ( STRING msg );
        FUNCTION DataReceived ( STRING msg , SIGNED_LONG_INTEGER length );
        FUNCTION ProcessResponse ( Request request , Response response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static INTEGER PRIORITY_COMMAND;
        static INTEGER PRIORITY_QUERY;

        // class properties
        INTEGER listenerID;
    };

     class MotorTypeMap 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static MotorTypeMap UNKNOWN;
        static MotorTypeMap AC;
        static MotorTypeMap DC;
        static MotorTypeMap CURTAIN;
        static MotorTypeMap SOCKET;
        static MotorTypeMap LIGHTING;

        // class properties
        SIGNED_LONG_INTEGER index;
        STRING protocolCmd[];
        STRING outputCmd[];
    };

     class ResponseCleaner 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION CleanResponse ( STRING msg );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class IntegerEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER payload;
    };

