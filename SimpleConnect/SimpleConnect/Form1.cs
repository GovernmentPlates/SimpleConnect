using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;
using System.Net;
using System.IO;

namespace SimpleConnect
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			updateIPDisplay();
		}

		public string btnStateStatus = "awaitingConnection";

		public void connectToVPN()
		{
			InputSimulator sim = new InputSimulator();

			string vpnUsername = "VPN-Username";
			string vpnPassword = "VPN-Password";

			sim.Keyboard.TextEntry(vpnUsername);
			sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
			sim.Keyboard.Sleep(500);
			sim.Keyboard.TextEntry(vpnPassword);
			sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
			sim.Keyboard.Sleep(500);
			sim.Keyboard.TextEntry("y");
			sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

		}

		private async void btnConnectVPN_Click(object sender, EventArgs e)
		{
			switch (btnStateStatus)
			{
				case "awaitingConnection":
					btnConnectVPN.Enabled = false;
					btnConnectVPN.Text = "Connecting...";
					Directory.SetCurrentDirectory(@"C:\Program Files (x86)\Cisco\Cisco AnyConnect Secure Mobility Client");
					System.Diagnostics.Process.Start("CMD.exe", "/C vpncli.exe connect vpn.example.com");
					await Task.Delay(2000);
					btnConnectVPN.Text = "Logging In...";
					connectToVPN();
					await Task.Delay(5000);
					btnConnectVPN.Enabled = true;
					btnConnectVPN.Text = "Disconnect";
					btnStateStatus = "connectionEstablished";
					updateIPDisplay();
					break;

				case "connectionEstablished":
					btnConnectVPN.Enabled = false;
					btnConnectVPN.Text = "Disconnecting...";
					System.Diagnostics.Process.Start("CMD.exe", "/C vpncli.exe disconnect");
					await Task.Delay(3850);
					btnStateStatus = "awaitingConnection";
					btnConnectVPN.Enabled = true;
					btnConnectVPN.Text = "Reconnect";
					updateIPDisplay();
					break;

			}
		}

		public void updateIPDisplay()
		{
			string publicIPv4 = new WebClient().DownloadString("http://icanhazip.com");
			viewPublicIP.Text = publicIPv4;
		}
	}
}
