using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Graph {
  [StructLayout( LayoutKind.Sequential, Pack = 1, Size = 7 )]
  public struct Position {
    public short X;
    public short Y;
    public short Z;
    public byte  Relay;
  }

  public partial class FileControl {
    public static uint TEXT_FROMAT  = 1;
    public static uint BIN_FROMAT   = 2;

    protected string fileName;
    protected FileInfo fInfo;
    protected List<Position> lines;
    protected uint format = FileControl.TEXT_FROMAT;

    public FileControl( string FileName ) {
      this.fileName = FileName;

      fInfo = new FileInfo( FileName );
      if(( fInfo.Extension == ".pr2" ) ||
          ( fInfo.Extension == ".prvk" )) {
        this.format = FileControl.TEXT_FROMAT;
      } else {
        this.format = FileControl.BIN_FROMAT;
      }

    }
    public void Load() {
      if(this.format == FileControl.TEXT_FROMAT) {
        loadText();
      }

    }

    /*======================================================*/
    protected void loadText() {
      Position point = new Position();
      var fileLines = File.ReadLines( this.fileName );
      string pattern = @"(\d*)";

      lines = new List<Position>();

      foreach(var line in fileLines) {
        var matches = Regex.Matches( line, pattern );
        
        if(matches.Count < 7) {
          Debug.WriteLine( " RegExp Error: " + line );
          continue;
        }

        point.X = short.Parse( matches[3*2].Value );
        point.Y = short.Parse( matches[4*2].Value );
        point.Z = short.Parse( matches[5*2].Value );
        point.Relay = byte.Parse( matches[2*2].Value );

        lines.Add( point );
      }
      Debug.WriteLine( "Size of struct: {0} count: {1} struc size: {2}", lines.Count * Marshal.SizeOf( point ), lines.Count, Marshal.SizeOf( point ) );
    }

    /*======================================================*/
    public List<Position> Data {
      get {
        return this.lines;
      }
    }

    public uint Length {
      get {
        if(this.format == FileControl.TEXT_FROMAT) {
          return (uint) this.lines.Count;
        }
        return 0;
      }
    }

  }
}
