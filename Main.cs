using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph {  
  public partial class MainForm : Form {
    protected FileControl file;
    protected GraphView graph;
    protected volatile USBControl usbControl;
    protected FormStatus fs;
    protected SetUp setup;
    protected DataSender dataSender;
    protected UInt32 frame = 0;

    public int startPosititon = 0;

    public MainForm() {
      InitializeComponent();
      graph = new GraphView();
      graph.Top = PositionBar.Height + PositionBar.Top;      
      this.Controls.Add( graph );
      graph.Dock = DockStyle.Fill;
      graph.BringToFront();
      usbControl = new USBControl();
      usbControl.initUsbDrv();
      USBName.Text = usbControl.name;
      fs = new FormStatus( usbControl );
      fs.Show( this );
      setup = new SetUp( usbControl );
      setup.Show( this );
    }
    private void Load( string fileName ) {
      file = new FileControl( fileName );
      file.Load();
      graph.Data = file.Data;
      if(dataSender != null) {
        dataSender.stop();
      }

      PositionBar.Maximum = (int) file.Length;
      PositionBar.Value = PositionBar.Minimum = 0;
      dataSender = new DataSender( usbControl, file );
      usbControl.sendPosition( 0 );
    }

    private void OpenFileMenuItem_Click( object sender, EventArgs e ) {
      var dialog = new OpenFileDialog();
      var result = dialog.ShowDialog();
      if(result != DialogResult.OK) {
        return;
      }
      Debug.WriteLine( dialog.FileName );
      this.Load( dialog.FileName );      
    }
    
    private void LoadButton_Click( object sender, EventArgs e ) {
      this.Load( "D:\\Privod\\по контроллеру\\прописание дорожек\\В плену у тьмы.pr2" );
    }

    private void PositionBar_ValueChanged( object sender, EventArgs e ) {
      this.startPosititon = PositionBar.Value;
      statusPositionLabel.Text = this.startPosititon.ToString();
      graph.Position = (uint) this.startPosititon;     
    }

    private void MainForm_FormClosed( object sender, FormClosedEventArgs e ) {
      dataSender.stop();
      fs.Close();
      usbControl.freeUsbDrv();      
    }

    private void startBtn_Click( object sender, EventArgs e ) {
      if(dataSender == null) {
        return;
      }
      dataSender.start();
    }

    private void btnStatus_Click( object sender, EventArgs e ) {
      if(fs.Visible) {
        fs.Hide();
      } else {
        fs.Show();
      }
    }

    private void reInitUsb_Click( object sender, EventArgs e ) {
      usbControl.freeUsbDrv();
      usbControl.initUsbDrv();
      USBName.Text = usbControl.name;
    }

    private void toolStripButton1_Click( object sender, EventArgs e ) {
      usbControl.flushFault();
    }
  }
}
