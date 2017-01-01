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

    unsafe public void setStatus(DEVICE_STATUS status) {
      DEVICE_STATUS ds = new DEVICE_STATUS();
      ds.point.posX = 100;
      ds.point.posY = 200;
      ds.point.posZ = 300;
      setStatus( device, &ds );      
    }

    unsafe public bool sendPoint( DEVICE_POINT point ) {
      int result;
      result = sendPoint( device, &point );
      return ( result == 1 );
    }

    unsafe public void freeUsbDrv() {
      freeUSB( this.device );      
    }
  }
}
