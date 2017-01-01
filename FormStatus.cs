using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph {
  public partial class FormStatus : Form {
    protected USBControl usbControl;
    protected StatusViewer listner;
    public FormStatus(USBControl uctrl) {      
      this.usbControl = uctrl;
      listner = new StatusViewer(this, uctrl);
      listner.start();
      InitializeComponent();
    }

    public void setUsbName( string name ) {      
      if((name != null) && (this.USBName != null)) {
        this.BeginInvoke( (MethodInvoker) ( () => {
          USBName.Text = name;
        } ) );
      }      
    }

    public void setPosition( UInt32 name ) {
      if( this.Position != null ) {
        Position.BeginInvoke( (MethodInvoker) ( () => this.Position.Text = name.ToString() ) );        
      }
    }

    public void setCurrentPosition( Int32 A, Int32 B, Int32 C, byte coils) {
      if(this.Position != null) {
        this.BeginInvoke( (MethodInvoker) ( () => {
          PosA.Text = A.ToString();
          PosB.Text = B.ToString();
          PosC.Text = C.ToString();

          lRalay1.BackColor = ( ( coils & 0x01 ) == 0x01 ) ? Color.Lime : Color.Red;
          lRalay2.BackColor = ( ( coils & 0x02 ) == 0x02 ) ? Color.Lime : Color.Red;
          lRalay3.BackColor = ( ( coils & 0x04 ) == 0x04 ) ? Color.Lime : Color.Red;
          lRalay4.BackColor = ( ( coils & 0x08 ) == 0x08 ) ? Color.Lime : Color.Red;
          
        } ) );
        
      }
    }

    public void setStatus( byte status ) {
      if(this.Position != null) {
        this.BeginInvoke( (MethodInvoker) ( () => {
          lInit.BackColor = ( ( status & 0x01 ) == 0x01 ) ? Color.Lime : Color.Red;
          lWork.BackColor = ( ( status & 0x02 ) == 0x02 ) ? Color.Lime : Color.Red;
          lError.BackColor= ( ( status & 0x04 ) == 0x04 ) ? Color.Lime : Color.Red;
          lFull.BackColor = ( ( status & 0x08 ) == 0x08 ) ? Color.Lime : Color.Red;
        } ) );
      }
    }

    public void setInputs( byte inputs ) {
      if(this.Position != null) {
        this.BeginInvoke( (MethodInvoker) ( () => {
          lIn1.BackColor = ( ( inputs & 0x01 ) == 0x01 ) ? Color.Lime : Color.Red;
          lIn2.BackColor = ( ( inputs & 0x02 ) == 0x02 ) ? Color.Lime : Color.Red;
          lIn3.BackColor = ( ( inputs & 0x04 ) == 0x04 ) ? Color.Lime : Color.Red;
          lIn4.BackColor = ( ( inputs & 0x08 ) == 0x08 ) ? Color.Lime : Color.Red;
          lIn5.BackColor = ( ( inputs & 0x10 ) == 0x10 ) ? Color.Lime : Color.Red;
          lIn6.BackColor = ( ( inputs & 0x20 ) == 0x20 ) ? Color.Lime : Color.Red;
        } ) );
      }
    }

    private void FormStatus_FormClosed( object sender, FormClosedEventArgs e ) {
      listner.stop();
    }
  }
}
