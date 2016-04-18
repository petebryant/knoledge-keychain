using NBitcoin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knoledge_keychain
{
    public partial class FormVanityAddress : Form
    {
        bool _exitLoop = false;
        object _padlock = new object();
        int _count = 0;
        CancellationTokenSource _cts = new CancellationTokenSource();
        public FormVanityAddress()
        {
            InitializeComponent();
        }

        private async void buttonFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxVanity.Text)) return;

            _exitLoop = false;
            _count = 0;

            buttonFind.Enabled = false;
            textBoxVanity.Enabled = false;

            string findM = "M" + textBoxVanity.Text.ToUpper();
            string findN = "N" + textBoxVanity.Text.ToUpper();

            _cts = new CancellationTokenSource();

            Task[] tasks = new Task[2];
            tasks[0] = FindVanityAddress(findM, findN);
            tasks[1] = FindVanityAddress(findM, findN);

            ClearOutput();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            await Task.WhenAll(tasks);

            watch.Stop();
            AppendToOutput("Iterations.." + _count + " in " + watch.Elapsed);

            buttonFind.Enabled = true;
            textBoxVanity.Enabled = true;
        }

        private Task FindVanityAddress(string findM, string findN)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                Key key;
                PubKey pubkey;
                BitcoinAddress address;
                string vanity;

                AppendToOutput("Starting... Thread:" + Thread.CurrentThread.ManagedThreadId);

                using (new HourGlass())
                {
                    while (!_exitLoop)
                    {
                        lock (_padlock)
                        {
                            _count++;
                        }

                        key = new Key();
                        pubkey = key.PubKey;
                        address = pubkey.GetAddress(Network.TestNet);

                        vanity = address.ToString().ToUpper();

                        if (vanity.StartsWith(findM) || vanity.StartsWith(findN))
                        {
                            AppendToOutput("Found after iterations: " + _count);
                            AppendToOutput("Public key: " + pubkey.ToString());
                            AppendToOutput("Address: " + address);
                            BitcoinSecret secret = key.GetBitcoinSecret(Network.TestNet);
                            AppendToOutput("Bitcoin Secret (WIF): " + secret);
                            _exitLoop = true;
                        }

                        if ((_count % 1000) == 0)
                            AppendToOutput("Iterations.." + _count);
                    }
                }

            }, _cts.Token);

            return task;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _exitLoop = true;
            _cts.Cancel();

            buttonFind.Enabled = true;
            textBoxVanity.Enabled = true;
        }

        private void FormVanityAddress_FormClosing(object sender, FormClosingEventArgs e)
        {
            _exitLoop = true;
            _cts.Cancel();
        }

        public void AppendToOutput(string text)
        {
            MethodInvoker method = delegate
            {
                if (textBoxOutput.IsDisposed) return;

                if (!string.IsNullOrEmpty(textBoxOutput.Text))
                    textBoxOutput.AppendText(Environment.NewLine);

                textBoxOutput.AppendText(text);
            };

            if (textBoxOutput.InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }

        public void ClearOutput()
        {
            MethodInvoker method = delegate
            {
                if (textBoxOutput.IsDisposed) return;

                textBoxOutput.Text = "";
            };

            if (textBoxOutput.InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }
    }
}
