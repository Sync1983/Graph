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
      fs.Show();
    }

    private void OpenFileMenuItem_Click( object sender, EventArgs e ) {
      var dialog = new OpenFileDialog();
      var result = dialog.ShowDialog();
      if(result != DialogResult.OK) {
        return;
      }
      Debug.WriteLine( dialog.FileName );
      file = new FileControl( dialog.FileName );
      file.Load();

      graph.Data = file.Data;
    }

    private void reDrawButton_Click( object sender, EventArgs e ) {
      graph.ReDraw();
    }

    private void LoadButton_Click( object sender, EventArgs e ) {
      file = new FileControl( "D:\\Privod\\по контроллеру\\прописание дорожек\\В плену у тьмы.pr2" );
      file.Load();
      graph.Data = file.Data;
      PositionBar.Maximum = (int) file.Length;
      PositionBar.Value = PositionBar.Minimum = 0;
    }

    private void PositionBar_ValueChanged( object sender, EventArgs e ) {
      this.startPosititon = PositionBar.Value;
      statusPositionLabel.Text = this.startPosititon.ToString();
      graph.Position = (uint) this.startPosititon;     
    }

    private void MainForm_FormClosed( object sender, FormClosedEventArgs e ) {
      fs.Close();
      usbControl.freeUsbDrv();      
    }

    private void startBtn_Click( object sender, EventArgs e ) {
      //usbControl.setStatus( new DEVICE_STATUS() );
      DEVICE_POINT dp = new DEVICE_POINT();
      int clk = 1000;
      while(clk > 0) {
        var data = file.Data[(int) frame];
        dp.posX = (short) data.X;
        dp.posY = (short) data.Y;
        dp.posZ = (short) data.Z;
        dp.coils = data.Relay;
        bool result = usbControl.sendPoint( dp );
        if(result) {
          frame++;
          clk--;
        }
      }
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
  }
}
