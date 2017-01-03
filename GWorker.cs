using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Graph;

namespace Graph {
  public abstract class GWorker {    
    protected Thread th;
    protected bool _canWork = false;
    public GWorker() {
      this.th = new Thread( this.Doing );
    }
    public void start() {
      if(_canWork) {
        return;
      }
      _canWork = true;
      th.Start();
    }    

    public void stop() {
      _canWork = false;
      th.Join();
    }

    protected abstract void work();
    
    protected void Doing() {
      while(_canWork) {        
        this.work();        
      }
    }

  }
}
