using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows;

namespace Graph {
  [StructLayout( LayoutKind.Sequential, Pack = 1 )]
  public struct DEVICE_POINT {
    public Int16  posX;
    public Int16  posY;
    public Int16  posZ;
    public byte  coils;
  };
  [StructLayout( LayoutKind.Sequential, Pack = 1 )]
  public struct DEVICE_STATUS {
    public DEVICE_POINT point;
    public byte inputs;
    public byte status;    
    public UInt32 position;
  };

  public partial class USBControl {
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll", CallingConvention = CallingConvention.Cdecl )]
    unsafe protected static extern void *initDeviceInfoStruct();
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll", CallingConvention = CallingConvention.Cdecl )]
    unsafe protected static extern int getUSBname( void* device );
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll", CallingConvention = CallingConvention.Cdecl )]
    unsafe protected static extern int freeUSB( void* device );
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll",CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]    
    unsafe protected static extern void* getName( void *device );
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll", CallingConvention = CallingConvention.Cdecl )]
    unsafe protected static extern int initUsb( void* device );
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll", CallingConvention = CallingConvention.Cdecl )]
    unsafe protected static extern int getStatus( void* device, DEVICE_STATUS* status );
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll", CallingConvention = CallingConvention.Cdecl )]
    unsafe protected static extern int setStatus( void* device, DEVICE_STATUS* status );
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll", CallingConvention = CallingConvention.Cdecl )]
    unsafe protected static extern int sendPoint( void* device, DEVICE_POINT* point );
    [DllImport( "d:/GitHub/graph/Graph/x64/Debug/ssctousbdll.dll", CallingConvention = CallingConvention.Cdecl )]
    unsafe protected static extern int sendCommand( void* device, byte cmd, UInt16 wIndex, UInt16 wValue, void* Buf, byte bufSize );

    unsafe protected void* device;
    protected string _name;
    protected bool isInit = false;
    public string name {
      get{
        return _name;
      }
    }

    public USBControl() {
      this.isInit = false;
    }
    unsafe public void initUsbDrv() {      
      void *strPtr;     
      device = initDeviceInfoStruct();
      if( getUSBname( device ) == 0 ) {
        return;
      };
      strPtr = getName( device );
      _name = Marshal.PtrToStringUni( (IntPtr) strPtr );
      initUsb( device );
      isInit = true;
    }

    unsafe public DEVICE_STATUS getStatus() {
      DEVICE_STATUS ds = new DEVICE_STATUS();
      if( isInit ) {
        getStatus( device, &ds );
      }      
      return ds;
    }

    unsafe public bool sendControl( byte bRequest, UInt16 wIndex, UInt16 wValue, byte[] extend = null, byte size = 0) {
      void* pExt = null;
      if(extend != null) {
        pExt = (void*)extend[0];
      }
      return sendCommand( device, bRequest, wIndex, wValue, pExt, size ) != 0;
    }

    public bool sendPosition( UInt16 Pos ) {
      return sendControl( 0xA0, 0, (UInt16) Pos );
    }

    public bool proclaimCoord( byte num, Int16 Value ) {
      return sendControl( 0xA1, num, (UInt16) Value );
    }

    public bool changeSpeed( UInt16 Value ) {
      return sendControl( 0xA2, 0, Value );
    }

    public bool flushFault() {
      return sendControl( 0xA3, 0, 0 );
    }

    public bool proclaimZero( byte num, Int16 Value ) {
      return sendControl( 0xA4, num, (UInt16) Value );
    }

    public bool startInitilize() {
      return sendControl( 0xA5, 0, 0 );
    }


    unsafe public bool sendPoint( DEVICE_POINT point ) {
      if(!isInit) {
        return false;
      }      
      return ( sendPoint( device, &point ) == 1 );
    }

    unsafe public void freeUsbDrv() {
      if(!isInit) {
        return;
      }
      isInit = false;
      freeUSB( this.device );      
    }
  }
}
