namespace Graph {
  partial class MainForm {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose( bool disposing ) {
      if(disposing && ( components != null )) {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.StatusBar = new System.Windows.Forms.StatusStrip();
      this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.USBName = new System.Windows.Forms.ToolStripStatusLabel();
      this.MenuBar = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.NotificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.ToolBar = new System.Windows.Forms.ToolStrip();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.PositionBar = new System.Windows.Forms.HScrollBar();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.LoadButton = new System.Windows.Forms.ToolStripButton();
      this.startBtn = new System.Windows.Forms.ToolStripButton();
      this.pauseBtn = new System.Windows.Forms.ToolStripButton();
      this.stopBtn = new System.Windows.Forms.ToolStripButton();
      this.btnStatus = new System.Windows.Forms.ToolStripButton();
      this.btnUpload = new System.Windows.Forms.ToolStripButton();
      this.reInitUsb = new System.Windows.Forms.ToolStripButton();
      this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.предварительныйпросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.StatusBar.SuspendLayout();
      this.MenuBar.SuspendLayout();
      this.ToolBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // StatusBar
      // 
      this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.statusLabel1,
            this.statusPositionLabel,
            this.USBName});
      resources.ApplyResources(this.StatusBar, "StatusBar");
      this.StatusBar.Name = "StatusBar";
      // 
      // ProgressBar
      // 
      this.ProgressBar.Name = "ProgressBar";
      resources.ApplyResources(this.ProgressBar, "ProgressBar");
      // 
      // statusLabel1
      // 
      this.statusLabel1.Name = "statusLabel1";
      resources.ApplyResources(this.statusLabel1, "statusLabel1");
      // 
      // statusPositionLabel
      // 
      this.statusPositionLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.statusPositionLabel.Name = "statusPositionLabel";
      resources.ApplyResources(this.statusPositionLabel, "statusPositionLabel");
      this.statusPositionLabel.Text = global::Graph.Properties.Settings.Default.pos;
      // 
      // USBName
      // 
      this.USBName.Name = "USBName";
      resources.ApplyResources(this.USBName, "USBName");
      // 
      // MenuBar
      // 
      this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.сервисToolStripMenuItem});
      resources.ApplyResources(this.MenuBar, "MenuBar");
      this.MenuBar.Name = "MenuBar";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.OpenFileMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.предварительныйпросмотрToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
      // 
      // сохранитькакToolStripMenuItem
      // 
      this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
      resources.ApplyResources(this.сохранитькакToolStripMenuItem, "сохранитькакToolStripMenuItem");
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
      // 
      // правкаToolStripMenuItem
      // 
      this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem,
            this.отменадействияToolStripMenuItem1,
            this.toolStripSeparator3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.toolStripSeparator4,
            this.выделитьвсеToolStripMenuItem});
      this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
      resources.ApplyResources(this.правкаToolStripMenuItem, "правкаToolStripMenuItem");
      // 
      // отменадействияToolStripMenuItem
      // 
      this.отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
      resources.ApplyResources(this.отменадействияToolStripMenuItem, "отменадействияToolStripMenuItem");
      // 
      // отменадействияToolStripMenuItem1
      // 
      this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
      resources.ApplyResources(this.отменадействияToolStripMenuItem1, "отменадействияToolStripMenuItem1");
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
      // 
      // выделитьвсеToolStripMenuItem
      // 
      this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
      resources.ApplyResources(this.выделитьвсеToolStripMenuItem, "выделитьвсеToolStripMenuItem");
      // 
      // сервисToolStripMenuItem
      // 
      this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
      this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
      resources.ApplyResources(this.сервисToolStripMenuItem, "сервисToolStripMenuItem");
      // 
      // настройкиToolStripMenuItem
      // 
      this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
      resources.ApplyResources(this.настройкиToolStripMenuItem, "настройкиToolStripMenuItem");
      // 
      // параметрыToolStripMenuItem
      // 
      this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
      resources.ApplyResources(this.параметрыToolStripMenuItem, "параметрыToolStripMenuItem");
      // 
      // NotificationIcon
      // 
      resources.ApplyResources(this.NotificationIcon, "NotificationIcon");
      // 
      // ToolBar
      // 
      this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadButton,
            this.startBtn,
            this.pauseBtn,
            this.stopBtn,
            this.toolStripSeparator5,
            this.btnStatus,
            this.btnUpload,
            this.reInitUsb});
      resources.ApplyResources(this.ToolBar, "ToolBar");
      this.ToolBar.Name = "ToolBar";
      // 
      // PositionBar
      // 
      resources.ApplyResources(this.PositionBar, "PositionBar");
      this.PositionBar.Name = "PositionBar";
      this.PositionBar.ValueChanged += new System.EventHandler(this.PositionBar_ValueChanged);
      // 
      // OpenFileDialog
      // 
      this.OpenFileDialog.DefaultExt = "*.pr2";
      this.OpenFileDialog.FileName = "openFileDialog";
      resources.ApplyResources(this.OpenFileDialog, "OpenFileDialog");
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
      // 
      // LoadButton
      // 
      this.LoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      resources.ApplyResources(this.LoadButton, "LoadButton");
      this.LoadButton.Name = "LoadButton";
      this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
      // 
      // startBtn
      // 
      this.startBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.startBtn.Image = global::Graph.Properties.Resources.play_24x32;
      resources.ApplyResources(this.startBtn, "startBtn");
      this.startBtn.Name = "startBtn";
      this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
      // 
      // pauseBtn
      // 
      this.pauseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.pauseBtn.Image = global::Graph.Properties.Resources.pause_24x32;
      resources.ApplyResources(this.pauseBtn, "pauseBtn");
      this.pauseBtn.Name = "pauseBtn";
      // 
      // stopBtn
      // 
      this.stopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.stopBtn.Image = global::Graph.Properties.Resources.stop_32x32;
      resources.ApplyResources(this.stopBtn, "stopBtn");
      this.stopBtn.Name = "stopBtn";
      // 
      // btnStatus
      // 
      this.btnStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnStatus.Image = global::Graph.Properties.Resources.eye_24x18;
      resources.ApplyResources(this.btnStatus, "btnStatus");
      this.btnStatus.Name = "btnStatus";
      this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
      // 
      // btnUpload
      // 
      this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnUpload.Image = global::Graph.Properties.Resources.upload_24x32;
      resources.ApplyResources(this.btnUpload, "btnUpload");
      this.btnUpload.Name = "btnUpload";
      // 
      // reInitUsb
      // 
      this.reInitUsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.reInitUsb.Image = global::Graph.Properties.Resources.reload_18x21;
      resources.ApplyResources(this.reInitUsb, "reInitUsb");
      this.reInitUsb.Name = "reInitUsb";
      this.reInitUsb.Click += new System.EventHandler(this.reInitUsb_Click);
      // 
      // создатьToolStripMenuItem
      // 
      resources.ApplyResources(this.создатьToolStripMenuItem, "создатьToolStripMenuItem");
      this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
      // 
      // OpenFileMenuItem
      // 
      resources.ApplyResources(this.OpenFileMenuItem, "OpenFileMenuItem");
      this.OpenFileMenuItem.Name = "OpenFileMenuItem";
      this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
      // 
      // сохранитьToolStripMenuItem
      // 
      resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      // 
      // предварительныйпросмотрToolStripMenuItem
      // 
      resources.ApplyResources(this.предварительныйпросмотрToolStripMenuItem, "предварительныйпросмотрToolStripMenuItem");
      this.предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
      // 
      // вырезатьToolStripMenuItem
      // 
      resources.ApplyResources(this.вырезатьToolStripMenuItem, "вырезатьToolStripMenuItem");
      this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
      // 
      // копироватьToolStripMenuItem
      // 
      resources.ApplyResources(this.копироватьToolStripMenuItem, "копироватьToolStripMenuItem");
      this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
      // 
      // вставкаToolStripMenuItem
      // 
      resources.ApplyResources(this.вставкаToolStripMenuItem, "вставкаToolStripMenuItem");
      this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
      // 
      // MainForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.PositionBar);
      this.Controls.Add(this.ToolBar);
      this.Controls.Add(this.StatusBar);
      this.Controls.Add(this.MenuBar);
      this.MainMenuStrip = this.MenuBar;
      this.Name = "MainForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.StatusBar.ResumeLayout(false);
      this.StatusBar.PerformLayout();
      this.MenuBar.ResumeLayout(false);
      this.MenuBar.PerformLayout();
      this.ToolBar.ResumeLayout(false);
      this.ToolBar.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip StatusBar;
    private System.Windows.Forms.ToolStripProgressBar ProgressBar;
    private System.Windows.Forms.MenuStrip MenuBar;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
    private System.Windows.Forms.NotifyIcon NotificationIcon;
    private System.Windows.Forms.ToolStrip ToolBar;
    private System.Windows.Forms.ToolTip ToolTip;    
    private System.Windows.Forms.HScrollBar PositionBar;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    private System.Windows.Forms.ToolStripButton LoadButton;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel statusPositionLabel;
    private System.Windows.Forms.ToolStripButton startBtn;
    private System.Windows.Forms.ToolStripButton pauseBtn;
    private System.Windows.Forms.ToolStripButton stopBtn;
    private System.Windows.Forms.ToolStripStatusLabel USBName;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton btnStatus;
    private System.Windows.Forms.ToolStripButton btnUpload;
    private System.Windows.Forms.ToolStripButton reInitUsb;
  }
}

