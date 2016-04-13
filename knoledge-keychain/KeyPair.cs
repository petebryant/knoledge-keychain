using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knoledge_keychain
{
    public class KeyPair
    {
        Network _network = Network.TestNet;

        public string PrivateKeyString
        {
            get 
            {
                if (PrivateKey == null)
                    return "unknown";
                else
                    return PrivateKey.ToString();
            }
        }

        public BitcoinExtKey PrivateKey { get; set; }
        public BitcoinExtPubKey PubKey { get; set; }
        public BitcoinAddress Address { get; set; }

        public KeyPair()
        {
            PrivateKey = new ExtKey().GetWif(_network);
            PubKey = PrivateKey.ExtKey.Neuter().GetWif(_network);
            Address = PubKey.ScriptPubKey.GetDestinationAddress(_network);
        }

        public KeyPair(ExtPubKey pubKey)
        {
            PubKey = new BitcoinExtPubKey(pubKey, Network.TestNet);
            Address = PubKey.ScriptPubKey.GetDestinationAddress(Network.TestNet);
        }
    }
}
