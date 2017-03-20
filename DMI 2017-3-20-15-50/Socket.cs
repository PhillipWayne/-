using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;


namespace MMI
{

    class Socket
    {
        private IPEndPoint ipLocalPoint;
        private EndPoint RemotePoint;
        private System.Net.Sockets.Socket mySocket;
        public bool runningFlag = false;
        public int localPort = 0;
        public int sendPort = 0;
        public int length = 0;
        public byte[] recv = new byte[1024];
        public byte[] sendBuf_ = new byte[1024];
        //public delegate void RcvDelegate(byte[] data);
        public delegate void RefDelegate();
        //public event RcvDelegate rcvEvent;
        public event RefDelegate refEvent;
        public string TrainNum = "";
        public byte CurModel = 0;
        public byte HighModel = 0;
        public UInt16 TargetLoca = 0;
        public UInt16 TargetSpeed = 0;
        public UInt16 ActulSpeed =0;
        public UInt16 PermitSpeed =0;
        public UInt16 HighSpeed = 0;
        public UInt16 FrontPermSpeed = 0;
        Thread thread;
        MyStruct Struct;
        public byte[] SendBuf { get { return sendBuf_; } }
        

        //public Socket()
        //{
        //    rcvEvent += new RcvDelegate(processData);            
        //}
        public void Start(string ip, int port,string dIP,int dPort)
        {
            Struct = new MyStruct();
            localPort = port;
            ipLocalPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(dIP), dPort);
            RemotePoint = (EndPoint)(ipep);
            mySocket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            mySocket.Bind(ipLocalPoint);
            runningFlag = true;
            thread = new Thread(new ThreadStart(this.ReceiveHandle));
            thread.IsBackground = true;
            thread.Start();           
        }

        public void Send(int packageSize, string dIP, int dPort)
        {
            sendPort = dPort;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(dIP), dPort);
            RemotePoint = (EndPoint)(ipep);
            mySocket.SendTo(sendBuf_, packageSize, SocketFlags.None, RemotePoint);
        }
        private void ReceiveHandle()
        {
            while (runningFlag)
            {
                try
                {
                    length = mySocket.ReceiveFrom(recv, ref RemotePoint);
                    if (length > 0 && recv[2]==3)
                    {
                        processData(recv);
                    }
                    //rcvEvent.Invoke(recv);
                    recv = new byte[1024];
                }
                catch(Exception e)
                {
                }
            }
        }
        private void processData(byte[] data)
        {
            Struct.PackedSize = 0;
            UInt16 Cycle = Struct.UnpackUint16(recv);
            UInt16 PackageType = Struct.UnpackUint16(recv);
            UInt16 Length = Struct.UnpackUint16(recv);
            TrainNum = Struct.UnPackString(recv);
            UInt32 TrainID = Struct.UnpackIDUint32(recv);
            HighModel = Struct.UnpackByte(recv);
            CurModel = Struct.UnpackByte(recv);
            byte CurRate = Struct.UnpackByte(recv);
            byte BreakOut = Struct.UnpackByte(recv);
            UInt32 TrainStation = Struct.UnpackUint32(recv);
            UInt32 TrainHeadLoca = Struct.UnpackUint32(recv);
            TargetLoca = Struct.UnpackUint16(recv);
            UInt16 StartLoca = Struct.UnpackUint16(recv);
            ActulSpeed = Struct.UnpackUint16(recv);
            HighSpeed = Struct.UnpackUint16(recv);
            UInt16 OpenSpeed = Struct.UnpackUint16(recv);
            PermitSpeed = Struct.UnpackUint16(recv);
            UInt16 InterSpeed = Struct.UnpackUint16(recv);
            TargetSpeed = Struct.UnpackUint16(recv);
            byte Alarm = Struct.UnpackByte(recv);
            UInt16 TempLimitSpeedStart1 = Struct.UnpackUint16(recv);
            UInt16 TempLimitSpeedEnd1 = Struct.UnpackUint16(recv);
            UInt16 TempLimitSpeed1 = Struct.UnpackUint16(recv);
            UInt16 TempLimitSpeedStart2 = Struct.UnpackUint16(recv);
            UInt16 TempLimitSpeedEnd2 = Struct.UnpackUint16(recv);
            UInt16 TempLimitSpeed2 = Struct.UnpackUint16(recv);
            UInt16 TempLimitSpeedStart3 = Struct.UnpackUint16(recv);
            UInt16 TempLimitSpeedEnd3 = Struct.UnpackUint16(recv);
            UInt16 TempLimitSpeed3 = Struct.UnpackUint16(recv);
            byte RunLocation = Struct.UnpackByte(recv);
            byte RunDirection = Struct.UnpackByte(recv);
            byte Hint = Struct.UnpackByte(recv);
            FrontPermSpeed = Struct.UnpackUint16(recv);
                        
            if (PackageType == 3)//表示ATP发来的数据
            {
                refEvent.Invoke();
            }

        }
        public void closeThread()
        {
            thread.Abort();
        }
    }
}
