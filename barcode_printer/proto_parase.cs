using System;
using System.Collections.Generic;
using System.Text;

namespace proto_parase
{
    public class packet_msg
    {
        public byte addr;
        public byte cmd;
        public byte len;
        public byte[] data;
        public DateTime time;
    }
    public class proto_parase
    {
        public delegate void procedure_packet(packet_msg msg);
        public event procedure_packet on_packet_data;
        private packet_msg _msg = new packet_msg();
        private void clear()
        {
            Array.Clear(recv_data, 0, 8);
            recv_count = 0;
        }
        private bool start_flag = false;
        private byte[] recv_data = new byte[8];
        private int recv_count = 0;
        public void push_byte(byte data)
        {
            if (data == 0x02 && !start_flag)
            {
                start_flag = true;
                clear();
                _msg.time = DateTime.Now;
            }
            recv_data[recv_count++] = data;
            if (recv_count >= 8)
            {
                int idx = 1;
                byte cs = 0;
                _msg.addr = recv_data[idx++];
                _msg.cmd = recv_data[idx++];
                _msg.len = (byte)(recv_data[idx++] & 0x3);
                cs ^= _msg.addr;
                cs ^= _msg.cmd;
                cs ^= _msg.len;
                _msg.data = new byte[_msg.len];
                for (int i = 0; i < _msg.len; i++)
                {
                    _msg.data[i] = recv_data[idx++];
                    cs ^= _msg.data[i];
                }
                if (_msg.len < 2)
                    cs ^= 0xFF;
                if (cs == recv_data[6] && recv_data[7] == 0x3)
                {
                    if (on_packet_data != null)
                    {
                        on_packet_data(_msg);
                    }
                }
                clear();
                start_flag = false;
            }
        }
    }
}
