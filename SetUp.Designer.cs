namespace Graph {
  partial class SetUp {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing ) {
      if(disposing && ( components != null )) {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.posChange = new System.Windows.Forms.Button();
      this.fullPosititon = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.posA = new System.Windows.Forms.NumericUpDown();
      this.setPosA = new System.Windows.Forms.Button();
      this.setPosB = new System.Windows.Forms.Button();
      this.posB = new System.Windows.Forms.NumericUpDown();
      this.setPosC = new System.Windows.Forms.Button();
      this.posC = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.setSpeed = new System.Windows.Forms.Button();
      this.speed = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.dPozA = new System.Windows.Forms.NumericUpDown();
      this.btnInit = new System.Windows.Forms.Button();
      this.dPozB = new System.Windows.Forms.NumericUpDown();
      this.dPozC = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.fullPosititon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.posA)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.posB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.posC)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dPozA)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dPozB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dPozC)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(160, 30);
      this.label1.TabIndex = 5;
      this.label1.Text = "Установить позицию";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // posChange
      // 
      this.posChange.Location = new System.Drawing.Point(335, 3);
      this.posChange.Name = "posChange";
      this.posChange.Size = new System.Drawing.Size(160, 24);
      this.posChange.TabIndex = 6;
      this.posChange.Text = "Изменить";
      this.posChange.UseVisualStyleBackColor = true;
      this.posChange.Click += new System.EventHandler(this.posChange_Click_1);
      // 
      // fullPosititon
      // 
      this.fullPosititon.Location = new System.Drawing.Point(169, 5);
      this.fullPosititon.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
      this.fullPosititon.Name = "fullPosititon";
      this.fullPosititon.Size = new System.Drawing.Size(160, 20);
      this.fullPosititon.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(3, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(160, 24);
      this.label2.TabIndex = 8;
      this.label2.Text = "Задать текущую координату";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // posA
      // 
      this.posA.Location = new System.Drawing.Point(169, 33);
      this.posA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.posA.Name = "posA";
      this.posA.Size = new System.Drawing.Size(160, 20);
      this.posA.TabIndex = 9;
      // 
      // setPosA
      // 
      this.setPosA.Location = new System.Drawing.Point(335, 31);
      this.setPosA.Name = "setPosA";
      this.setPosA.Size = new System.Drawing.Size(160, 24);
      this.setPosA.TabIndex = 10;
      this.setPosA.Text = "Изменить";
      this.setPosA.UseVisualStyleBackColor = true;
      this.setPosA.Click += new System.EventHandler(this.setPosA_Click);
      // 
      // setPosB
      // 
      this.setPosB.Location = new System.Drawing.Point(335, 57);
      this.setPosB.Name = "setPosB";
      this.setPosB.Size = new System.Drawing.Size(160, 24);
      this.setPosB.TabIndex = 12;
      this.setPosB.Text = "Изменить";
      this.setPosB.UseVisualStyleBackColor = true;
      this.setPosB.Click += new System.EventHandler(this.setPosB_Click);
      // 
      // posB
      // 
      this.posB.Location = new System.Drawing.Point(169, 59);
      this.posB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.posB.Name = "posB";
      this.posB.Size = new System.Drawing.Size(160, 20);
      this.posB.TabIndex = 11;
      // 
      // setPosC
      // 
      this.setPosC.Location = new System.Drawing.Point(335, 83);
      this.setPosC.Name = "setPosC";
      this.setPosC.Size = new System.Drawing.Size(160, 24);
      this.setPosC.TabIndex = 14;
      this.setPosC.Text = "Изменить";
      this.setPosC.UseVisualStyleBackColor = true;
      this.setPosC.Click += new System.EventHandler(this.setPosC_Click);
      // 
      // posC
      // 
      this.posC.Location = new System.Drawing.Point(169, 85);
      this.posC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.posC.Name = "posC";
      this.posC.Size = new System.Drawing.Size(160, 20);
      this.posC.TabIndex = 13;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(3, 106);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(160, 30);
      this.label3.TabIndex = 15;
      this.label3.Text = "Установить скорость";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // setSpeed
      // 
      this.setSpeed.Location = new System.Drawing.Point(335, 109);
      this.setSpeed.Name = "setSpeed";
      this.setSpeed.Size = new System.Drawing.Size(160, 24);
      this.setSpeed.TabIndex = 16;
      this.setSpeed.Text = "Изменить";
      this.setSpeed.UseVisualStyleBackColor = true;
      this.setSpeed.Click += new System.EventHandler(this.setSpeed_Click);
      // 
      // speed
      // 
      this.speed.Location = new System.Drawing.Point(169, 111);
      this.speed.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
      this.speed.Minimum = new decimal(new int[] {
            130,
            0,
            0,
            0});
      this.speed.Name = "speed";
      this.speed.Size = new System.Drawing.Size(160, 20);
      this.speed.TabIndex = 17;
      this.speed.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(3, 132);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(160, 30);
      this.label4.TabIndex = 18;
      this.label4.Text = "Инициализировать по координатам";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // dPozA
      // 
      this.dPozA.Location = new System.Drawing.Point(169, 137);
      this.dPozA.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
      this.dPozA.Name = "dPozA";
      this.dPozA.Size = new System.Drawing.Size(160, 20);
      this.dPozA.TabIndex = 20;
      this.dPozA.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.dPozA.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // btnInit
      // 
      this.btnInit.Location = new System.Drawing.Point(335, 161);
      this.btnInit.Name = "btnInit";
      this.btnInit.Size = new System.Drawing.Size(160, 24);
      this.btnInit.TabIndex = 21;
      this.btnInit.Text = "Начать";
      this.btnInit.UseVisualStyleBackColor = true;
      this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
      // 
      // dPozB
      // 
      this.dPozB.Location = new System.Drawing.Point(169, 163);
      this.dPozB.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
      this.dPozB.Name = "dPozB";
      this.dPozB.Size = new System.Drawing.Size(160, 20);
      this.dPozB.TabIndex = 22;
      this.dPozB.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // dPozC
      // 
      this.dPozC.Location = new System.Drawing.Point(169, 189);
      this.dPozC.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
      this.dPozC.Name = "dPozC";
      this.dPozC.Size = new System.Drawing.Size(160, 20);
      this.dPozC.TabIndex = 24;
      this.dPozC.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // SetUp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(498, 214);
      this.Controls.Add(this.dPozC);
      this.Controls.Add(this.btnInit);
      this.Controls.Add(this.dPozB);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.dPozA);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.setSpeed);
      this.Controls.Add(this.speed);
      this.Controls.Add(this.setPosC);
      this.Controls.Add(this.posC);
      this.Controls.Add(this.setPosB);
      this.Controls.Add(this.posB);
      this.Controls.Add(this.setPosA);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.posChange);
      this.Controls.Add(this.fullPosititon);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.posA);
      this.Name = "SetUp";
      this.Text = "SetUp";
      ((System.ComponentModel.ISupportInitialize)(this.fullPosititon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.posA)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.posB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.posC)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dPozA)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dPozB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dPozC)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button posChange;
    private System.Windows.Forms.NumericUpDown fullPosititon;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown posA;
    private System.Windows.Forms.Button setPosA;
    private System.Windows.Forms.Button setPosB;
    private System.Windows.Forms.NumericUpDown posB;
    private System.Windows.Forms.Button setPosC;
    private System.Windows.Forms.NumericUpDown posC;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button setSpeed;
    private System.Windows.Forms.NumericUpDown speed;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown dPozA;
    private System.Windows.Forms.Button btnInit;
    private System.Windows.Forms.NumericUpDown dPozB;
    private System.Windows.Forms.NumericUpDown dPozC;
  }
}