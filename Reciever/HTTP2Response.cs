using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciever
{
    public class HTTP2Response
    {
        //HEADER
        private int Length = 2148;
        private string binaryLength => Convert.ToString(Length, 2).PadLeft(24, '0');
        private bool Type = false; //0 - DATA 1-Headers
        private string binaryType => Type ? "00000001" : "00000000";
        //Flags
        private bool END_STREAM = false;//END_STREAM (0x1) PADDED (0x8)
        private string binaryEND_STREAM => END_STREAM ? "1" : "0";
        private bool PADDED = false; //Добавлять ли смещение 
        private string binaryPADDED => PADDED ? "1" : "0";

        private bool R = false; //0 при отправке , игнорируется при получении.
        private string binaryR => R ? "1" : "0";
        private int StreamIdentifier = 629353;//Идентификатор потока указан для примера.
        private string binaryStreamIdentifier => Convert.ToString(StreamIdentifier, 2).PadLeft(31, '0');
        //DATA
        private int PadLength = 153;
        private string binaryPadLength => Convert.ToString(PadLength, 2).PadLeft(8, '0');
        private long Data = 15314643224;
        private string binaryData => Convert.ToString(Data, 2).PadLeft(Length + (PADDED ? PadLength : 0), '0');

        public string ToString(bool readable)
        {
            if (readable)
            {
                return
                $"Length:{binaryLength}\n" +
                $"Type:{binaryType}\n" +
                $"Flags:{binaryEND_STREAM}00{binaryPADDED}0000\n" +
                $"  END_STREAM:{binaryEND_STREAM}\n" +
                $"  PADDED:{binaryPADDED}\n" +
                $"Stream:{binaryR}{binaryStreamIdentifier}\n" +
                $"  R:{binaryR}\n" +
                $"  StreamIdentifier:{binaryStreamIdentifier}\n" +
                $"PadLength:{binaryPadLength}\n" +
                $"DATA:{Convert.ToString(Data, 2)}";
            }
            else
            {
                return
                    $"{binaryLength} " +
                    $"{binaryType} " +
                    $"{binaryEND_STREAM}00{binaryPADDED}0000 " +
                    $"{binaryR}{binaryStreamIdentifier}" +
                    $"{binaryPadLength}" +
                    $"{binaryData}";
            }
        }
        public string GetHiddenBinary()
        {
            if (!PADDED)
            {
                return "1";
            }
            else
            {
                if (PADDED && PadLength == 0)
                {
                    return "0";
                }
            }
            return "0";
        }
        public HTTP2Response(string binaryString)
        {
            var message = binaryString.Substring(1).Split(' ');
            Length = Convert.ToInt32(message[0].Trim('0'),2);
            Type = message[1] == "1";
            END_STREAM = message[2].Substring(0, 1) == "1";
            PADDED = message[2].Substring(3, 1) == "1";
            R = message[3].Substring(0, 1) == "1";
            StreamIdentifier = Convert.ToInt32(message[3].Substring(1).Trim('0'),2);
            try
            {
                PadLength = Convert.ToInt32(message[4].Trim('0'), 2);
                Data = Convert.ToInt64(message[5].Trim('0'), 2);
            }
            catch { }
        }
        public HTTP2Response(bool AsHiddenOne)
        {
            if (AsHiddenOne)
            {
                PADDED = false;
            }
            else
            {
                PADDED = true;
                PadLength = 0;
            }
        }
    }

    public class IPv4Response
    {
        //HEADER
        private int Version = 4;
        private string binaryVersion => Tools.ToBinaryString(Version, 4);

        private int HeaderLength = 14;
        private string binaryHeaderLength => Tools.ToBinaryString(HeaderLength, 14);

        private int TOS = 100;
        private string binaryTOS => Tools.ToBinaryString(TOS, 8);

        private int TotalLength = 20000;
        private string binaryTotalLength => Tools.ToBinaryString(TotalLength, 16);

        private int Identification;
        private string binaryIdentification => Tools.ToBinaryString(Identification, 16);

        private int Flags = 3;
        private string binaryFlags => Tools.ToBinaryString(Flags, 3);

        private int FragmentOffset = 623;
        private string binaryFragmentOffset => Tools.ToBinaryString(FragmentOffset, 13);

        private int TTL = 50;
        private string binaryTTL => Tools.ToBinaryString(TTL, 8);

        private int Proto = 4;
        private string binaryProto => Tools.ToBinaryString(Proto, 8);

        private int HeaderChecksum;
        private string binaryHeaderChecksum => Tools.ToBinaryString(HeaderChecksum, 16);

        private uint SourceIPAddress;
        private string binarySourceIPAddress => Tools.ToBinaryString(SourceIPAddress, 32);

        private uint DestinationIPAddress;
        private string binaryDestinationIPAddress => Tools.ToBinaryString(DestinationIPAddress, 32);


        public string ToString(bool readable)
        {
            if (readable)
            {
                return
                $"Version:{binaryVersion}\n" +
                $"HeaderLength:{binaryHeaderLength}\n" +
                $"TOS:{binaryTOS}\n" +
                $"TotalLength:{binaryTotalLength}\n" +
                $"Identification:{binaryIdentification}\n" +
                $"Flags:{binaryFlags}\n" +
                $"FragmentOffset:{binaryFragmentOffset}\n" +
                $"TTL:{binaryTTL}\n" +
                $"Proto:{binaryProto}\n" +
                $"HeaderChecksum:{binaryHeaderChecksum}\n" +
                $"SourceIPAddress:{binarySourceIPAddress}\n" +
                $"DestinationIPAddress:{binaryDestinationIPAddress}\n";
            }
            else
            {
                return
                $"{binaryVersion} " +
                $"{binaryHeaderLength} " +
                $"{binaryTOS} " +
                $"{binaryTotalLength} " +
                $"{binaryIdentification} " +
                $"{binaryFlags} " +
                $"{binaryFragmentOffset} " +
                $"{binaryTTL} " +
                $"{binaryProto} " +
                $"{binaryHeaderChecksum} " +
                $"{binarySourceIPAddress} " +
                $"{binaryDestinationIPAddress}";
            }
        }
        public string GetHiddenBinary()
        {
            return binaryIdentification;
        }
        public IPv4Response(string binaryString)
        {
            var message = binaryString.Split(' ');
            Version = Convert.ToInt32(message[0]);
            HeaderLength = Convert.ToInt32(message[1]);
            TOS = Convert.ToInt32(message[2]);
            TotalLength = Convert.ToInt32(message[3]);
            Identification = Convert.ToInt32(message[4]);
            Flags = Convert.ToInt32(message[5]);
            FragmentOffset = Convert.ToInt32(message[6]);
            TTL = Convert.ToInt32(message[7]);
            Proto = Convert.ToInt32(message[8]);
            HeaderChecksum = Convert.ToInt32(message[9]);
            SourceIPAddress = Convert.ToUInt32(message[10]);
            DestinationIPAddress = Convert.ToUInt32(message[11]);
        }
        public void SetHiddenMessage(string hiddenMessage)
        {
            Identification = Convert.ToInt32(hiddenMessage);
        }
    }

    public static class Tools
    {
        public static string ToBinaryString(int val, int bins)
        {
            return Convert.ToString(val, 2).PadLeft(bins, '0');
        }
        public static string ToBinaryString(uint val, int bins)
        {
            return Convert.ToString(val, 2).PadLeft(bins, '0');
        }
    }
}
