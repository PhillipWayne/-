using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace MMI
{
    public partial class Form1 : Form
    {
        public static string sourceIP = "";
        public static string sourcePort = "";
        public static string desIP = "";
        public static string desPort = "";        
        string[] highestDrivingMode = { "RM", "BLOC-CM", "BlOC-AM", "CBTC-CM", "CBTC-AM" };
        string[] currentDrivingMode = { "RM", "CM", "AM", "EUM", "RD", "AR" };
        Socket socket;
        DMIPackage DMIPackage_;
        public Form1()
        {           
            InitializeComponent();
            socket=new Socket();
            DMIPackage_ = new DMIPackage();
            ConfigurationData.ReadConfigData();            
            socket.Start(sourceIP, Convert.ToInt32(sourcePort),desIP,Convert.ToInt32(desPort));
            Control.CheckForIllegalCrossThreadCalls = false;
            this.KeyPreview = true;
            timer_DateAndTime.Enabled = true;
            timer_DateAndTime.Interval = 1000;//设置日期和时间的更新频率
            //timer_refreshChart.Enabled = true;
            //timer_refreshChart.Interval = 1000;//更新图标周期
            a2_TargetDistance1.Distance = 750;
            a2_TargetDistance1.Speed= 0;
            b_AGauge1.CurSpeed = 60;
            b_AGauge1.RecommedSpeed_ = 40;
            b_AGauge1.RecommedSpeed = 70;
            b_AGauge1.LimitSpeed = 80;            
            this.WindowState = FormWindowState.Maximized;
            int wid = Screen.PrimaryScreen.WorkingArea.Width;
            int hei = Screen.PrimaryScreen.WorkingArea.Height;
            panel1.Height=650;
            panel1.Width = 810;
            panel1.Location = new Point(wid / 2 - 430, hei / 2 - 330);
            a1_CurState1.Location = new Point(wid / 2 - 380, hei / 2 - 290);
            a2_TargetDistance1.Location = new Point(wid / 2 - 380, hei / 2 - 220);
            b_AGauge1.Location = new Point(wid / 2 - 240, hei / 2 - 250);
            lbl_trainNum.Location = new Point(wid / 2 + 90, hei / 2 - 300);
            lbl_T2_nextStation.Location = new Point(wid / 2 + 180, hei / 2 - 300);
            lbl_T3_driver.Location = new Point(wid / 2 + 250, hei / 2 - 300);
            N.Location = new Point(wid / 2 + 100, hei / 2 - 240);
            btn_D_INFO.Location = new Point(wid / 2 + 230, hei / 2 - 240);
            lbl_M1_curMode.Location = new Point(wid / 2 + 110, hei / 2 - 170);
            M2.Location = new Point(wid / 2 + 240, hei / 2 - 170);
            m31.Location= new Point(wid / 2 + 100, hei / 2 - 120);
            m41.Location = new Point(wid / 2 + 230, hei / 2 - 120);
            m51.Location = new Point(wid / 2 + 100, hei / 2 - 60);
            m61.Location = new Point(wid / 2 + 230, hei / 2 - 60);
            lbl_HighModel.Location = new Point(wid / 2 + 110, hei / 2 + 20);
            doorState1.Location = new Point(wid / 2 + 230, hei / 2 -10);
            departSign1.Location = new Point(wid/2+100,hei/2+140);
            doorState1.Location = new Point(wid / 2 + 230, hei / 2 + 20);
            m91.Location = new Point(wid / 2 + 100, hei / 2 + 80);
            m101.Location = new Point(wid / 2 + 230, hei / 2 + 80);
            c11.Location = new Point(wid / 2 - 400, hei / 2 + 80);
            //lbl_C2.Location = new Point(wid / 2 - 270, hei / 2 + 80);
            c31.Location = new Point(wid / 2 - 160, hei / 2 + 80);
            c51.Location = new Point(wid / 2 + 20, hei / 2 + 80);
            lbl_curDate.Location = new Point(wid / 2 - 380, hei / 2 + 210);
            lbl_curTime.Location = new Point(wid / 2 - 200, hei / 2 + 210);
            socket.refEvent += new Socket.RefDelegate(refreshChart);
        }

        public void SetupTimer()
        {
            System.Timers.Timer timer = new System.Timers.Timer(5);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            int DCPackageSize = DMIPackage_.Pack(socket.SendBuf);
            socket.Send(DCPackageSize, desIP, Convert.ToInt32(desPort));
        }
        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dr = MessageBox.Show("确定要退出程序吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    socket.closeThread();
                    this.Close();

                }
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        public void refreshChart()
        {            
            lbl_M1_curMode.Text = currentDrivingMode[Convert.ToInt32(socket.CurModel) - 1];
            lbl_HighModel.Text = highestDrivingMode[Convert.ToInt32(socket.HighModel) - 1];
            lbl_trainNum.Text = socket.TrainNum;
            b_AGauge1.CurSpeed = socket.ActulSpeed;
            b_AGauge1.RecommedSpeed = socket.PermitSpeed;
            b_AGauge1.RecommedSpeed_ = socket.FrontPermSpeed;//当下一个区段降速是才出现，否则不出现
            b_AGauge1.LimitSpeed = socket.HighSpeed;
            a1_CurState1.LimitSpeed = socket.HighSpeed;
            a1_CurState1.CurSpeed = socket.ActulSpeed;
            a2_TargetDistance1.Distance = socket.TargetLoca;
            a2_TargetDistance1.Speed = socket.PermitSpeed;
            this.Refresh();
        }
        // 日期和时间的更新
        public void timer_DateAndTime_Tick(object sender, EventArgs e)
        {
            lbl_curDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbl_curTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        //数据分别为： 当前速度 / ATP推荐速度 / 限制速度 / 目标距离 / 目标速度
        public void timer_refreshChart_Tick(object sender, EventArgs e)
        {
        //    a1_CurState1.CurSpeed = b_AGauge1.CurSpeed = Socket.curSpeed;
        //    b_AGauge1.RecommedSpeed = Socket.recommedSpeed;
        //    a1_CurState1.LimitSpeed = b_AGauge1.LimitSpeed = Socket.limitSpeed;
        //    a2_TargetDistance1.Distance = Socket.targetDistance;
        //    a2_TargetDistance1.Speed = Socket.targetSpeed;
        //  //  this.Refresh();
       }

        public void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出程序吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
