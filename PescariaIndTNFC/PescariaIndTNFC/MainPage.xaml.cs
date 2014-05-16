using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Networking.Proximity;
using NdefLibrary.Ndef;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.Devices;
using System.Windows.Media.Imaging;
using System.Windows.Media;



namespace PescariaIndTNFC
{
    public partial class MainPage : PhoneApplicationPage
    {

        private ProximityDevice _device;
        private long _subscriptionIdNdef;
        private long _publishingMessageId;

        public MainPage()
        {
            InitializeComponent();
            NFCBegin();
           
          
        }
        #region NFC

        private void NFCBegin()
        {
            _device = ProximityDevice.GetDefault();
            _device.SubscribeForMessage("NDEF", MessageReceivedHandler);

        }
        private void MessageReceivedHandler(ProximityDevice sender, ProximityMessage message)
        {
            var rawMsg = message.Data.ToArray();
            var ndefMessage = NdefMessage.FromByteArray(rawMsg);

            var tagContents = new StringBuilder();
            String texto;
            foreach (NdefRecord record in ndefMessage) {
                var data = new NdefTextRecord(record);
                texto = data.Text;
            }

            UpdateUIforNfcStatus();
        }

        private void UpdateUIforNfcStatus()
        {
            Dispatcher.BeginInvoke(() =>
            {
                Random rand = new Random();
                int nRand = rand.Next(1, 2);
              //  MessageBox.Show("Voce ganhou o premio "  + rand.Next(1,10).ToString());
                AguaSom.Stop();
                Aplauso.Play();
                ImageSource premio;
                if (nRand == 1)
                {
                     premio = new BitmapImage(new Uri("/Imagens/pacoca.jpg", UriKind.RelativeOrAbsolute));
                     foto.Source = premio;
                }
                if (nRand == 2)
                {
                    premio = new BitmapImage(new Uri("/Imagens/chinelo.jpg", UriKind.RelativeOrAbsolute));
                    foto.Source = premio;
                }
              
               foto.Stretch = Stretch.Fill;
            });
        }
        #endregion

        private void AguaSom_MediaEnded(object sender, RoutedEventArgs e)
        {
            AguaSom.Play();
        }

        private void Aplauso_MediaEnded(object sender, RoutedEventArgs e)
        {
            Aplauso.Play();
        }

    }
}