
using NBitcoin;
using NBitcoin.DataEncoders;
using NBitcoin.OpenAsset;
using NBitcoin.Stealth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace knoledge_keychain
{

    public class Util
    {
        public static object InterpretAddress(string what)
        {
            if (what == null) return null;

            what = what.Trim();
            Base58Type? type = GetBase58Type(what);
            Network network = Network.TestNet;

            if (type == null) return null;

            switch (type)
            {
                case Base58Type.COLORED_ADDRESS:                            // BitcoinColoredAddress(BitcoinAddress);
                    return new BitcoinColoredAddress(what, network);
                case Base58Type.PUBKEY_ADDRESS:                             // Key.PubKey.GetAddress(Network.TestNet);
                    return new BitcoinAddress(what, network);
                case Base58Type.SCRIPT_ADDRESS:                             // PubKey.ScriptPubKey.GetScriptAddress(Network.TestNet)
                    return new BitcoinScriptAddress(what, network);
                case Base58Type.STEALTH_ADDRESS:                            // BitcoinStealthAddress( Key.PubKey, new[] { Key.PubKey }, 1, null, Network.TestNet);
                    return new BitcoinStealthAddress(what, network);
                case Base58Type.MAX_BASE58_TYPES:
                default:
                    return null;
            }
        }
        public static object Interpret(string what)
        {
            if (what == null) return null;

            what = what.Trim();
            Base58Type? type = GetBase58Type(what);
            Network network =  Network.TestNet;

            if (type == null) return null;

            switch (type)
            {
                case Base58Type.ASSET_ID:                                   // AssetId(BitcoinAddress).GetWif(Network.TestNet);
                    return new BitcoinAssetId(what);
                case Base58Type.COLORED_ADDRESS:                            // BitcoinColoredAddress(BitcoinAddress);
                    return new BitcoinColoredAddress(what, network);
                case Base58Type.CONFIRMATION_CODE:                          // Key.ConfirmationCode
                    return new BitcoinConfirmationCode(what, network);
                case Base58Type.ENCRYPTED_SECRET_KEY_EC:                    // BitcoinPassphraseCode("my secret", Network.TestNet, null).GenerateEncryptedSecret().EncryptedKey
                    return new BitcoinEncryptedSecretEC(what, network);
                case Base58Type.ENCRYPTED_SECRET_KEY_NO_EC:                 // BitcoinEncryptedSecretNoEC(Key,"Password", Network.TestNet);
                    return new BitcoinEncryptedSecretNoEC(what, network);
                case Base58Type.EXT_PUBLIC_KEY:                             // Key.PubKey;
                    return ExtPubKey.Parse(what, Network.TestNet);
                case Base58Type.EXT_SECRET_KEY:                             // BitcoinExtKey(ExtKey.GetWif(Network.TestNet), Network.TestNet);
                    return new BitcoinExtKey(what, network);
                case Base58Type.PASSPHRASE_CODE:                            // BitcoinPassphraseCode("my secret", Network.TestNet, null);
                    return new BitcoinPassphraseCode(what, network);
                case Base58Type.PUBKEY_ADDRESS:                             // Key.PubKey.GetAddress(Network.TestNet);
                    return new BitcoinAddress(what, network);
                case Base58Type.SCRIPT_ADDRESS:                             // PubKey.ScriptPubKey.GetScriptAddress(Network.TestNet)
                    return new BitcoinScriptAddress(what, network);
                case Base58Type.SECRET_KEY:                                 // Key.GetBitcoinSecret(Network.TestNet)
                    return new BitcoinSecret(what, network);
                case Base58Type.STEALTH_ADDRESS:                            // BitcoinStealthAddress( Key.PubKey, new[] { Key.PubKey }, 1, null, Network.TestNet);
                    return new BitcoinStealthAddress(what, network);
                case Base58Type.MAX_BASE58_TYPES:
                default:
                    return null;
            }
        }

        public static Base58Type? GetBase58Type(string base58)
        {
            try
            {
                byte[][] base58Prefixes = new byte[12][];
                base58Prefixes[(int)Base58Type.PUBKEY_ADDRESS] = new byte[] { (111) };
                base58Prefixes[(int)Base58Type.SCRIPT_ADDRESS] = new byte[] { (196) };
                base58Prefixes[(int)Base58Type.SECRET_KEY] = new byte[] { (239) };
                base58Prefixes[(int)Base58Type.ENCRYPTED_SECRET_KEY_NO_EC] = new byte[] { 0x01, 0x42 };
                base58Prefixes[(int)Base58Type.ENCRYPTED_SECRET_KEY_EC] = new byte[] { 0x01, 0x43 };
                base58Prefixes[(int)Base58Type.EXT_PUBLIC_KEY] = new byte[] { (0x04), (0x35), (0x87), (0xCF) };
                base58Prefixes[(int)Base58Type.EXT_SECRET_KEY] = new byte[] { (0x04), (0x35), (0x83), (0x94) };
                base58Prefixes[(int)Base58Type.PASSPHRASE_CODE] = new byte[] { 0x2C, 0xE9, 0xB3, 0xE1, 0xFF, 0x39, 0xE2 };
                base58Prefixes[(int)Base58Type.CONFIRMATION_CODE] = new byte[] { 0x64, 0x3B, 0xF6, 0xA8, 0x9A };
                base58Prefixes[(int)Base58Type.STEALTH_ADDRESS] = new byte[] { 0x2b };
                base58Prefixes[(int)Base58Type.ASSET_ID] = new byte[] { 115 };
                base58Prefixes[(int)Base58Type.COLORED_ADDRESS] = new byte[] { 0x13 };

                var bytes = Encoders.Base58Check.DecodeData(base58);
                for (int i = 0; i < base58Prefixes.Length; i++)
                {
                    var prefix = base58Prefixes[i];
                    if (bytes.Length < prefix.Length)
                        continue;
                    if (Utils.ArrayEqual(bytes, 0, prefix, 0, prefix.Length))
                        return (Base58Type)i;
                }
            }
            catch { }

            return null;
        }
    }
}

