namespace MMI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_curDate = new System.Windows.Forms.Label();
            this.lbl_curTime = new System.Windows.Forms.Label();
            this.lbl_trainNum = new System.Windows.Forms.Label();
            this.lbl_M1_curMode = new System.Windows.Forms.Label();
            this.btn_D_INFO = new System.Windows.Forms.Button();
            this.M2 = new System.Windows.Forms.Label();
            this.lbl_HighModel = new System.Windows.Forms.Label();
            this.lbl_T2_nextStation = new System.Windows.Forms.Label();
            this.lbl_T3_driver = new System.Windows.Forms.Label();
            this.timer_DateAndTime = new System.Windows.Forms.Timer(this.components);
            this.timer_refreshChart = new System.Windows.Forms.Timer(this.components);
            this.contxtMenuStrip_btn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModeChange = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.departSign1 = new MMI.UIControl.DepartSign();
            this.doorState1 = new MMI.UIControl.DoorState();
            this.c11 = new MMI.UIControl.C1();
            this.c51 = new MMI.UIControl.C5();
            this.c31 = new MMI.UIControl.C3();
            this.m101 = new MMI.UIControl.M10();
            this.m91 = new MMI.UIControl.M9();
            this.m61 = new MMI.UIControl.M6();
            this.m51 = new MMI.UIControl.M5();
            this.m41 = new MMI.UIControl.M4();
            this.m31 = new MMI.UIControl.M3();
            this.N = new MMI.UIControl.N();
            this.b_AGauge1 = new MMI.UIControl.B_AGauge();
            this.a1_CurState1 = new MMI.UIControl.A1_CurState();
            this.a2_TargetDistance1 = new MMI.A2_TargetDistance();
            this.contxtMenuStrip_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_curDate
            // 
            this.lbl_curDate.AutoSize = true;
            this.lbl_curDate.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_curDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_curDate.Location = new System.Drawing.Point(36, 512);
            this.lbl_curDate.Name = "lbl_curDate";
            this.lbl_curDate.Size = new System.Drawing.Size(140, 24);
            this.lbl_curDate.TabIndex = 3;
            this.lbl_curDate.Text = "2017-03-17";
            // 
            // lbl_curTime
            // 
            this.lbl_curTime.AutoSize = true;
            this.lbl_curTime.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_curTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_curTime.Location = new System.Drawing.Point(201, 512);
            this.lbl_curTime.Name = "lbl_curTime";
            this.lbl_curTime.Size = new System.Drawing.Size(114, 24);
            this.lbl_curTime.TabIndex = 4;
            this.lbl_curTime.Text = "00:00:00";
            // 
            // lbl_trainNum
            // 
            this.lbl_trainNum.AutoSize = true;
            this.lbl_trainNum.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_trainNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_trainNum.Location = new System.Drawing.Point(491, 23);
            this.lbl_trainNum.Name = "lbl_trainNum";
            this.lbl_trainNum.Size = new System.Drawing.Size(75, 24);
            this.lbl_trainNum.TabIndex = 5;
            this.lbl_trainNum.Text = "T0291";
            // 
            // lbl_M1_curMode
            // 
            this.lbl_M1_curMode.AutoSize = true;
            this.lbl_M1_curMode.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_M1_curMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_M1_curMode.Location = new System.Drawing.Point(512, 128);
            this.lbl_M1_curMode.Name = "lbl_M1_curMode";
            this.lbl_M1_curMode.Size = new System.Drawing.Size(77, 46);
            this.lbl_M1_curMode.TabIndex = 7;
            this.lbl_M1_curMode.Text = "RM";
            // 
            // btn_D_INFO
            // 
            this.btn_D_INFO.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_D_INFO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_D_INFO.Location = new System.Drawing.Point(627, 59);
            this.btn_D_INFO.Name = "btn_D_INFO";
            this.btn_D_INFO.Size = new System.Drawing.Size(105, 64);
            this.btn_D_INFO.TabIndex = 9;
            this.btn_D_INFO.Text = "INFO";
            this.btn_D_INFO.UseVisualStyleBackColor = false;
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.M2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.M2.Location = new System.Drawing.Point(639, 126);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(71, 46);
            this.M2.TabIndex = 10;
            this.M2.Text = "IXL";
            // 
            // lbl_HighModel
            // 
            this.lbl_HighModel.AutoSize = true;
            this.lbl_HighModel.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_HighModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_HighModel.Location = new System.Drawing.Point(510, 318);
            this.lbl_HighModel.Name = "lbl_HighModel";
            this.lbl_HighModel.Size = new System.Drawing.Size(79, 46);
            this.lbl_HighModel.TabIndex = 15;
            this.lbl_HighModel.Text = "AM";
            // 
            // lbl_T2_nextStation
            // 
            this.lbl_T2_nextStation.AutoSize = true;
            this.lbl_T2_nextStation.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_T2_nextStation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_T2_nextStation.Location = new System.Drawing.Point(578, 22);
            this.lbl_T2_nextStation.Name = "lbl_T2_nextStation";
            this.lbl_T2_nextStation.Size = new System.Drawing.Size(49, 24);
            this.lbl_T2_nextStation.TabIndex = 24;
            this.lbl_T2_nextStation.Text = "D45";
            // 
            // lbl_T3_driver
            // 
            this.lbl_T3_driver.AutoSize = true;
            this.lbl_T3_driver.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_T3_driver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_T3_driver.Location = new System.Drawing.Point(647, 22);
            this.lbl_T3_driver.Name = "lbl_T3_driver";
            this.lbl_T3_driver.Size = new System.Drawing.Size(88, 24);
            this.lbl_T3_driver.TabIndex = 25;
            this.lbl_T3_driver.Text = "C00987";
            // 
            // timer_DateAndTime
            // 
            this.timer_DateAndTime.Enabled = true;
            this.timer_DateAndTime.Interval = 1000;
            this.timer_DateAndTime.Tick += new System.EventHandler(this.timer_DateAndTime_Tick);
            // 
            // timer_refreshChart
            // 
            this.timer_refreshChart.Tick += new System.EventHandler(this.timer_refreshChart_Tick);
            // 
            // contxtMenuStrip_btn
            // 
            this.contxtMenuStrip_btn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModeChange,
            this.Exit});
            this.contxtMenuStrip_btn.Name = "contextMenuStrip1";
            this.contxtMenuStrip_btn.Size = new System.Drawing.Size(101, 48);
            // 
            // ModeChange
            // 
            this.ModeChange.Name = "ModeChange";
            this.ModeChange.Size = new System.Drawing.Size(100, 22);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 22);
            this.Exit.Text = "退出";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 604);
            this.panel1.TabIndex = 26;
            // 
            // departSign1
            // 
            this.departSign1.BackColor = System.Drawing.Color.Black;
            this.departSign1.Location = new System.Drawing.Point(499, 467);
            this.departSign1.Name = "departSign1";
            this.departSign1.Size = new System.Drawing.Size(100, 60);
            this.departSign1.TabIndex = 2;
            // 
            // doorState1
            // 
            this.doorState1.BackColor = System.Drawing.Color.Black;
            this.doorState1.DoorStatus = MMI.UIControl.DoorState.DoorStateInformation.close;
            this.doorState1.Location = new System.Drawing.Point(627, 318);
            this.doorState1.Name = "doorState1";
            this.doorState1.Size = new System.Drawing.Size(100, 60);
            this.doorState1.TabIndex = 1;
            // 
            // c11
            // 
            this.c11.Location = new System.Drawing.Point(6, 377);
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(120, 60);
            this.c11.TabIndex = 19;
            this.c11.TractionAndBrakingState = MMI.UIControl.C1.TractionBrakingState.traction;
            // 
            // c51
            // 
            this.c51.IsOppositeCommunicationRight = true;
            this.c51.Location = new System.Drawing.Point(421, 375);
            this.c51.Name = "c51";
            this.c51.Size = new System.Drawing.Size(60, 60);
            this.c51.TabIndex = 21;
            // 
            // c31
            // 
            this.c31.IsTrainIntergrality = true;
            this.c31.Location = new System.Drawing.Point(238, 384);
            this.c31.Name = "c31";
            this.c31.Size = new System.Drawing.Size(100, 52);
            this.c31.TabIndex = 20;
            // 
            // m101
            // 
            this.m101.Location = new System.Drawing.Point(625, 375);
            this.m101.Name = "m101";
            this.m101.Size = new System.Drawing.Size(99, 60);
            this.m101.TabIndex = 18;
            // 
            // m91
            // 
            this.m91.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m91.Location = new System.Drawing.Point(496, 375);
            this.m91.Name = "m91";
            this.m91.OperateStatus = MMI.UIControl.M9.OperatingStatus.ATOfailure;
            this.m91.Size = new System.Drawing.Size(100, 60);
            this.m91.TabIndex = 17;
            // 
            // m61
            // 
            this.m61.Location = new System.Drawing.Point(622, 243);
            this.m61.Name = "m61";
            this.m61.Size = new System.Drawing.Size(100, 60);
            this.m61.TabIndex = 14;
            // 
            // m51
            // 
            this.m51.Location = new System.Drawing.Point(494, 241);
            this.m51.Name = "m51";
            this.m51.Opentype = MMI.UIControl.M5.OpenType.bothOpen;
            this.m51.Size = new System.Drawing.Size(100, 60);
            this.m51.Stopwindow = MMI.UIControl.M5.StopWindow.ATPwindow;
            this.m51.TabIndex = 13;
            // 
            // m41
            // 
            this.m41.BackColor = System.Drawing.Color.Black;
            this.m41.IsReachStopPlace = false;
            this.m41.Location = new System.Drawing.Point(623, 177);
            this.m41.Name = "m41";
            this.m41.Size = new System.Drawing.Size(97, 60);
            this.m41.TabIndex = 12;
            // 
            // m31
            // 
            this.m31.BackColor = System.Drawing.Color.Black;
            this.m31.IsAR = false;
            this.m31.Location = new System.Drawing.Point(494, 177);
            this.m31.Name = "m31";
            this.m31.Size = new System.Drawing.Size(100, 63);
            this.m31.TabIndex = 11;
            // 
            // N
            // 
            this.N.BackColor = System.Drawing.Color.Black;
            this.N.IsJumpstop = true;
            this.N.Location = new System.Drawing.Point(495, 67);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(104, 56);
            this.N.TabIndex = 8;
            // 
            // b_AGauge1
            // 
            this.b_AGauge1.BackColor = System.Drawing.Color.Transparent;
            this.b_AGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_AGauge1.BackgroundImage")));
            this.b_AGauge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_AGauge1.CurSpeed = 50F;
            this.b_AGauge1.LimitSpeed = 0F;
            this.b_AGauge1.Location = new System.Drawing.Point(154, 78);
            this.b_AGauge1.Name = "b_AGauge1";
            this.b_AGauge1.RecommedSpeed = 0F;
            this.b_AGauge1.Size = new System.Drawing.Size(314, 300);
            this.b_AGauge1.TabIndex = 2;
            // 
            // a1_CurState1
            // 
            this.a1_CurState1.CurSpeed = 10F;
            this.a1_CurState1.LimitSpeed = 20F;
            this.a1_CurState1.Location = new System.Drawing.Point(26, 15);
            this.a1_CurState1.Name = "a1_CurState1";
            this.a1_CurState1.Size = new System.Drawing.Size(100, 60);
            this.a1_CurState1.TabIndex = 1;
            // 
            // a2_TargetDistance1
            // 
            this.a2_TargetDistance1.Distance = 750F;
            this.a2_TargetDistance1.Location = new System.Drawing.Point(28, 81);
            this.a2_TargetDistance1.Name = "a2_TargetDistance1";
            this.a2_TargetDistance1.Size = new System.Drawing.Size(107, 297);
            this.a2_TargetDistance1.Speed = 100F;
            this.a2_TargetDistance1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1118, 693);
            this.ContextMenuStrip = this.contxtMenuStrip_btn;
            this.Controls.Add(this.departSign1);
            this.Controls.Add(this.doorState1);
            this.Controls.Add(this.c11);
            this.Controls.Add(this.lbl_T3_driver);
            this.Controls.Add(this.lbl_T2_nextStation);
            this.Controls.Add(this.c51);
            this.Controls.Add(this.c31);
            this.Controls.Add(this.m101);
            this.Controls.Add(this.m91);
            this.Controls.Add(this.lbl_HighModel);
            this.Controls.Add(this.m61);
            this.Controls.Add(this.m51);
            this.Controls.Add(this.m41);
            this.Controls.Add(this.m31);
            this.Controls.Add(this.M2);
            this.Controls.Add(this.btn_D_INFO);
            this.Controls.Add(this.N);
            this.Controls.Add(this.lbl_M1_curMode);
            this.Controls.Add(this.lbl_trainNum);
            this.Controls.Add(this.lbl_curTime);
            this.Controls.Add(this.lbl_curDate);
            this.Controls.Add(this.b_AGauge1);
            this.Controls.Add(this.a1_CurState1);
            this.Controls.Add(this.a2_TargetDistance1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.contxtMenuStrip_btn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private A2_TargetDistance a2_TargetDistance1;
        private UIControl.A1_CurState a1_CurState1;
        private UIControl.B_AGauge b_AGauge1;
        private System.Windows.Forms.Label lbl_curDate;
        private System.Windows.Forms.Label lbl_curTime;
        public  System.Windows.Forms.Label lbl_trainNum;
        public System.Windows.Forms.Label lbl_M1_curMode;
        private UIControl.N N;
        private System.Windows.Forms.Button btn_D_INFO;
        private System.Windows.Forms.Label M2;
        private UIControl.M3 m31;
        private UIControl.M4 m41;
        private UIControl.M5 m51;
        private UIControl.M6 m61;
        public System.Windows.Forms.Label lbl_HighModel;
        private UIControl.M9 m91;
        private UIControl.M10 m101;
        private UIControl.C1 c11;
        private UIControl.C3 c31;
        private UIControl.C5 c51;
        private System.Windows.Forms.Label lbl_T2_nextStation;
        private System.Windows.Forms.Label lbl_T3_driver;
        private System.Windows.Forms.Timer timer_DateAndTime;
        private System.Windows.Forms.Timer timer_refreshChart;
        private System.Windows.Forms.ContextMenuStrip contxtMenuStrip_btn;
        private System.Windows.Forms.ToolStripMenuItem ModeChange;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Panel panel1;
        private UIControl.DepartSign departSign1;
        private UIControl.DoorState doorState1;
       
    }
}

