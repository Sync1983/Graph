using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph {
  public partial class GraphView: Control{
    protected List<Position> items = null;
    protected Bitmap bmpBK = null;
    protected Pen penBkLines = null;
    protected BufferedGraphicsContext currentContext;
    protected BufferedGraphics buffer;
    protected Pen pX = new Pen( Color.Red );
    protected Pen pY = new Pen( Color.Green);
    protected Pen pZ = new Pen( Color.Yellow );
    protected int maxY = 0;

    protected int gridX = 5;
    protected int gridY = 20;

    protected uint visualStep = 0;

    public GraphView() {      
      float[] dashValues = { 4, 4 };
      penBkLines = new Pen( Color.FromArgb( 50, Color.Aqua ) );
      penBkLines.DashPattern = dashValues;

      currentContext = BufferedGraphicsManager.Current;      
    }

    protected override void OnCreateControl() {
      drawCell();
    }

    protected override void OnPaintBackground( PaintEventArgs pevent ) {
      return;
    }

    protected override void OnMouseWheel( MouseEventArgs e ) {
      base.OnMouseWheel( e );
      /*HStep += e.Delta;
      if(HStep <= 2) {
        HStep = 2;
      }
      ReDraw();*/
    }    

    protected override void OnSizeChanged( EventArgs e ) {
      base.OnSizeChanged( e );
      drawCell();
      ReDraw();
    }

    protected void drawCell() {
      Rectangle r = this.ClientRectangle;
      r.Inflate( -10, -10 );   
      bmpBK = new Bitmap( r.Width, r.Height );
      Graphics g = Graphics.FromImage( bmpBK );
          
      float stepX = r.Width / gridX;
      float stepY = r.Height / gridY;

      float posX = r.Left;
      float posY = r.Bottom - r.Top - 1;

      g.Clear( Color.Black );

      for(var i = 0; i <= gridX; i++) {
        g.DrawLine( penBkLines, posX, r.Top, posX, r.Bottom );
        posX += stepX;
      }

      for(var i = 0; i <= gridY; i++) {
        g.DrawLine( penBkLines, r.Left, posY, r.Right, posY );
        posY -= stepY;
      }

      g.DrawLine( penBkLines, 0, 0, this.Width, this.Height);

    }

    protected void drawData( Graphics g, Rectangle r ) {
      if(items == null) {
        return;
      }

      if(items.Count <= visualStep) {
        return;
      }
      
      int count = (int) Math.Round( (float) r.Width / gridX );
      count = Math.Min( count, items.Count - (int) visualStep );
      
      Point[] posX = new Point[count];
      Point[] posY = new Point[count];
      Point[] posZ = new Point[count];

      float vScale = (float)r.Height / this.maxY;
      
      for(var i = 0; i < count; i++) {
        int X = (int) Math.Round( (float) i * gridX) + r.Left;
        posX[i].X = X;
        posY[i].X = X;
        posZ[i].X = X;

        Position item = items[(int) visualStep + i];
        posX[i].Y = r.Bottom - (int) ( item.X * vScale);
        posY[i].Y = r.Bottom - (int) ( item.Y * vScale );
        posZ[i].Y = r.Bottom - (int) ( item.Z * vScale);        
      }
      
      g.DrawLines( pX, posX );
      g.DrawLines( pY, posY );
      g.DrawLines( pZ, posZ );
    }

    protected override void OnPaint( PaintEventArgs pe ) {
      buffer = currentContext.Allocate( this.CreateGraphics(), this.ClientRectangle );
      Graphics g = buffer.Graphics; 
      Rectangle r = this.ClientRectangle;
      Rectangle showRect = Rectangle.Inflate( r, -10, -10 );      
      ControlPaint.DrawBorder3D( g, r, Border3DStyle.Bump);
      g.DrawImageUnscaled( bmpBK, 10, 10 );
      
      this.drawData( g, showRect );

      buffer.Render();
      buffer.Dispose();
    }

    protected void findMax() {
      var max = -100;
      foreach(var item in this.items) {        
        max = Math.Max( max, item.X );
        max = Math.Max( max, item.Y );
        max = Math.Max( max, item.Z );
      }
      maxY = max;
    }

    public void ReDraw() {      
      Invalidate();
    }

    public List<Position> Data {
      set {
        this.items = value;
        findMax();
        ReDraw();
      }
      get {
        return this.items;
      }
    }

    public uint Position {
      get {
        return this.visualStep;
      }
      set {
        this.visualStep = value;
        ReDraw();
      }
    }
  }
}
