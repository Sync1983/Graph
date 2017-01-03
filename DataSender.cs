using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph {
  public partial class DataSender : GWorker {
    protected USBControl ctrl;
    protected FileControl file;
    protected UInt32 position;
    protected UInt32 length;
    protected DEVICE_POINT dp;
    public DataSender( USBControl usbControl, FileControl fileCtrl ) {
      this.ctrl = usbControl;
      this.file = fileCtrl;
    }
    protected override void work() {
      this.length = file.Length;
      if(position < length) {
        var data = file.Data[(int) position];
        dp.posX = (short) data.X;
        dp.posY = (short) data.Y;
        dp.posZ = (short) data.Z;
        dp.coils = data.Relay;
        bool result = ctrl.sendPoint( dp );
        if(result) {
          ++position;          
        }
      }
    }
  }
}
