using SKYPE4COMLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Plugin
{
    public partial class MainForm : Form
    {
        Skype skype;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Log("All logs will be visible in this box");
            skype = new SKYPE4COMLib.Skype();
            ((_ISkypeEvents_Event)skype).AttachmentStatus += OnAttach;
            skype.CallStatus += MainForm_CallStatus;
        }

        private void MainForm_CallStatus(Call pCall, TCallStatus status)
        {
            Log(String.Format("Call Stats Changed: {0}", status.ToString()));
            
            switch (status)
            {
                case TCallStatus.clsUnknown:
                    break;
                case TCallStatus.clsUnplaced:
                    break;
                case TCallStatus.clsRouting:
                    break;
                case TCallStatus.clsEarlyMedia:
                    break;
                case TCallStatus.clsFailed:
                    break;
                case TCallStatus.clsRinging:
                    Log(String.Format("Calling {0}({1})", pCall.PartnerDisplayName, pCall.PartnerHandle));
                    break;
                case TCallStatus.clsInProgress:
                    Log(String.Format("Calling {0}({1})", pCall.PartnerDisplayName, pCall.PartnerHandle));
                    break;
                case TCallStatus.clsOnHold:
                    break;
                case TCallStatus.clsFinished:
                    break;
                case TCallStatus.clsMissed:
                    break;
                case TCallStatus.clsRefused:
                    break;
                case TCallStatus.clsBusy:
                    break;
                case TCallStatus.clsCancelled:
                    break;
                case TCallStatus.clsLocalHold:
                    break;
                case TCallStatus.clsRemoteHold:
                    break;
                case TCallStatus.clsVoicemailBufferingGreeting:
                    break;
                case TCallStatus.clsVoicemailPlayingGreeting:
                    break;
                case TCallStatus.clsVoicemailRecording:
                    break;
                case TCallStatus.clsVoicemailUploading:
                    break;
                case TCallStatus.clsVoicemailSent:
                    break;
                case TCallStatus.clsVoicemailCancelled:
                    break;
                case TCallStatus.clsVoicemailFailed:
                    break;
                case TCallStatus.clsTransferring:
                    break;
                case TCallStatus.clsTransferred:
                    break;
            }
        }

        private void OnAttach(TAttachmentStatus status)
        {
            Log(String.Format("Call Stats Changed: {0}", status.ToString()));
            switch (status)
            {
                case TAttachmentStatus.apiAttachSuccess:
                    loggedAsLbl.Text = string.Format("{0} ({1})", skype.CurrentUser.FullName, skype.CurrentUser.Handle);
                    attachedBtn.Enabled = false;
                    break;
                case TAttachmentStatus.apiAttachNotAvailable:
                case TAttachmentStatus.apiAttachUnknown:
                case TAttachmentStatus.apiAttachPendingAuthorization:
                case TAttachmentStatus.apiAttachRefused:
                case TAttachmentStatus.apiAttachAvailable:
                    loggedAsLbl.Text = "Please allow skype access";
                    attachedBtn.Enabled = true;
                    break;
            }
        }

        private void attachedBtn_Click(object sender, EventArgs e)
        {
            Log("Trying to get access");
            if (skype.Client.IsRunning)
            {
                try
                {
                    skype.Attach(10, true);
                    Log("Got access");
                }
                catch (COMException)
                {
                    Log("Attach Request could not be sent. Try to restart Skype and the Application!");
                }
            }
            else
            {
                Log("Please make sure skype is working and you are logged with your skype id");
            }
        }

        private void Log(string message)
        {
            outputListBox.Items.Insert(0, message);
        }
    }
}
