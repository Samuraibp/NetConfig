using System.Net.NetworkInformation;

namespace NETConfigAndTrafficWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void buttonShow_Click(object sender, EventArgs e)
        {
            var adapters = NetworkInterface.GetAllNetworkInterfaces();
            listBoxDevices.Items.Clear();
            listBoxTCPConnection.Items.Clear();

            foreach (var adapter in adapters)
            {
                listBoxDevices.Items.Add($"Devic ID: {adapter.Id}");
                listBoxDevices.Items.Add($"Devic Name: {adapter.Name}");
                listBoxDevices.Items.Add($"Devic Description: {adapter.Description}");
                listBoxDevices.Items.Add($"Devic NetworkInterfaceType: {adapter.NetworkInterfaceType}");
                listBoxDevices.Items.Add($"Devic PhysicalAddress: {adapter.GetPhysicalAddress}");
                listBoxDevices.Items.Add($"Devic OperationalStatus: {adapter.OperationalStatus}");
                listBoxDevices.Items.Add($"Devic Speed: {adapter.Speed}");

                IPInterfaceStatistics stats = adapter.GetIPStatistics();
                listBoxDevices.Items.Add($"Recived: {stats.BytesReceived}");
                listBoxDevices.Items.Add($"Sent: {stats.BytesSent}");
                listBoxDevices.Items.Add("---------------------------------------------------------");
                listBoxDevices.Items.Add("\n");


                var ipProps = IPGlobalProperties.GetIPGlobalProperties();
                var tcpConnections = ipProps.GetActiveTcpConnections();

                listBoxTCPConnection.Items.Add($"Total {tcpConnections.Length} active connections");
                foreach (var tcpConnection in tcpConnections)
                {
                    listBoxTCPConnection.Items.Add($"Local address: {tcpConnection.LocalEndPoint.Address} - {tcpConnection.LocalEndPoint.Port}");
                    listBoxTCPConnection.Items.Add($"Local address: {tcpConnection.RemoteEndPoint.Address} - {tcpConnection.RemoteEndPoint.Port}");
                    listBoxTCPConnection.Items.Add($"Connection status: {tcpConnection.State}");
                    listBoxTCPConnection.Items.Add("--------------------------------------");

                }


                ipProps = IPGlobalProperties.GetIPGlobalProperties();
                var ipStats = ipProps.GetIPv4GlobalStatistics();
                listBoxTotal.Items.Add($"Incoming packets: {ipStats.ReceivedPackets}");
                listBoxTotal.Items.Add($"Outcoming packets: {ipStats.OutputPacketRequests}");
                listBoxTotal.Items.Add($"Refused incoming packets: {ipStats.ReceivedPacketsDiscarded}");
                listBoxTotal.Items.Add($"Refused outcoming packets: {ipStats.OutputPacketsDiscarded}");
                listBoxTotal.Items.Add($"Packets fragment failures: {ipStats.PacketFragmentFailures}");
                listBoxTotal.Items.Add($"Packets reassembly failures: {ipStats.PacketReassemblyFailures}");
                listBoxTotal.Items.Add("--------------------------------------");
            }
        }
    } 
}
