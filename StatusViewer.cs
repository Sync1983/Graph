using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Graph {
  public partial class StatusViewer : GWorker {
    protected FormStatus stFrom;
    protected USBControl usbControl;
    protected DEVICE_STATUS status;
    public StatusViewer( FormStatus fs, USBControl uctrl ) {
      this.stFrom = fs;
      this.usbControl = uctrl;
    }
    protected override void work() {
      stFrom.setUsbName( usbControl.name );
      status = usbControl.getStatus();
      stFrom.setPosition( status.position );
      stFrom.setCurrentPosition( status.point.posX, status.point.posY, status.point.posZ, status.point.coils );
      stFrom.setInputs( status.inputs );
      stFrom.setStatus( status.status );
      Thread.Sleep( 500 );
    }
  }
}
