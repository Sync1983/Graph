using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph {
  public partial class SetUp : Form {
    private USBControl ctrl;    
    public SetUp( USBControl control ) {
      this.ctrl = control;
      InitializeComponent();
    }

    private void posChange_Click( object sender, EventArgs e ) {
      
    }

    private void setPosA_Click( object sender, EventArgs e ) {
      ctrl.proclaimCoord( 0, (short) posA.Value );      
    }

    private void setPosB_Click( object sender, EventArgs e ) {
      ctrl.proclaimCoord( 1, (short) posB.Value );      
    }

    private void setPosC_Click( object sender, EventArgs e ) {
      ctrl.proclaimCoord( 2, (short) posC.Value );      
    }

    private void setSpeed_Click( object sender, EventArgs e ) {
      ctrl.changeSpeed( (ushort) speed.Value );      
    }

    private void posChange_Click_1( object sender, EventArgs e ) {
      ctrl.sendPosition( (ushort) fullPosititon.Value );      
    }

    private void label4_Click( object sender, EventArgs e ) {

    }

    private void button1_Click( object sender, EventArgs e ) {

    }

    private void numericUpDown1_ValueChanged( object sender, EventArgs e ) {

    }

    private void btnInit_Click( object sender, EventArgs e ) {
      ctrl.proclaimZero( 0, (short) dPozA.Value );
      ctrl.proclaimZero( 1, (short) dPozB.Value );
      ctrl.proclaimZero( 2, (short) dPozC.Value );
      Thread.Sleep( 500 );
      ctrl.startInitilize();
    }
  }

}
