using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliver_Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tmrTopFlash.Stop();
            tmrTopSecondary.Stop();
            tmrJungleFlash.Stop();
            tmrMidFlash.Stop();
            tmrMidSecondary.Stop();
            tmrADCFlash.Stop();
            tmrSupportFlash.Stop();
            tmrSupportSecondary.Stop();
            tmrADCSecondary.Stop();

            cmbTopSecondary.SelectedIndex = 0;
            cmbMidSecondary.SelectedIndex = 0;
            cmbADCSecondary.SelectedIndex = 0;
            cmbSupportSecondary.SelectedIndex = 0;

            picMidBarrier.BringToFront();
        }
        //TO DO LIST
        //Teleport Cancel Button use enabled methods to ensure validation
        //Drop Down boxes for most Popular Summs
        //Ionian compounding
        //Change names to Secondary
        
        double TopFlashTimer;
        double TopSecondaryTimer;
        double JungleFlashTimer;
        double MidFlashTimer;
        double MidSecondaryTimer;
        double ADCFlashTimer;
        double ADCSecondaryTimer;
        double SupportFlashTimer;
        double SupportSecondaryTimer;

        private void picTopFlash_Click(object sender, EventArgs e)
        {
            TopFlashTimer = 300;
            if (chkTopCD.Checked)
            {
                if (chkTopIonian.Checked)
                {
                    TopFlashTimer = 225;
                }
                else
                {
                    TopFlashTimer = 255;
                }
            }
            else if (chkTopIonian.Checked)
            {
                TopFlashTimer = 270;
            }
            TimeSpan TopFlashTimespan = TimeSpan.FromSeconds(TopFlashTimer);
            lblTopFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                TopFlashTimespan.Minutes,
                TopFlashTimespan.Seconds);
            tmrTopFlash.Start();
            lblTopFlashAvailable.BackColor = Color.Red;
            picTopFlash.Enabled = false;
        }

        private void tmrTopFlash_Tick(object sender, EventArgs e)
        {
            if (TopFlashTimer > 0)
            {
                TopFlashTimer -= 1;
                TimeSpan TopFlashTimespan = TimeSpan.FromSeconds(TopFlashTimer);
                lblTopFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                    TopFlashTimespan.Minutes,
                    TopFlashTimespan.Seconds);
            }
            else
            {
                tmrTopFlash.Stop();
                lblTopFlashAvailable.BackColor = Color.Green;
                picTopFlash.Enabled = true;
            }
        }

        private void picTopTP_Click(object sender, EventArgs e)
        {
            TopSecondaryTimer = 300;
            if (chkTopCD.Checked)
            {
                if (chkTopIonian.Checked)
                {
                    TopSecondaryTimer = 225;
                }
                else
                {
                    TopSecondaryTimer = 255;
                }
            }
            else if (chkTopIonian.Checked)
            {
                TopSecondaryTimer = 270;
            }
            picTopTP.Enabled = false;
            HandleTopSecondary();
        }

        private void picTopIgnite_Click(object sender, EventArgs e)
        {
            TopSecondaryTimer = 210;
            if (chkTopCD.Checked)
            {
                if (chkTopIonian.Checked)
                {
                    TopSecondaryTimer = 157.5;
                }
                else
                {
                    TopSecondaryTimer = 178.5;
                }
            }
            else if (chkTopIonian.Checked)
            {
                TopSecondaryTimer = 189;
            }
            picTopIgnite.Enabled = false;
            HandleTopSecondary();
        }

        private void picTopExhaust_Click(object sender, EventArgs e)
        {
            TopSecondaryTimer = 210;
            if (chkTopCD.Checked)
            {
                if (chkTopIonian.Checked)
                {
                    TopSecondaryTimer = 157.5;
                }
                else
                {
                    TopSecondaryTimer = 178.5;
                }
            }
            else if (chkTopIonian.Checked)
            {
                TopSecondaryTimer = 189;
            }
            picTopExhaust.Enabled = false;
            HandleTopSecondary();
        }

        private void HandleTopSecondary()
        {
            TimeSpan TopTPTimespan = TimeSpan.FromSeconds(TopSecondaryTimer);
            lblTopSecondaryCount.Text = string.Format("{0:D2}:{1:D2}",
                TopTPTimespan.Minutes,
                TopTPTimespan.Seconds);
            tmrTopSecondary.Start();
            lblTopSecondaryAvailable.BackColor = Color.Red;
        }
        private void tmrTopTP_Tick(object sender, EventArgs e)
        {
            if (TopSecondaryTimer > 0)
            {
                TopSecondaryTimer -= 1;
                TimeSpan TopTPTimespan = TimeSpan.FromSeconds(TopSecondaryTimer);
                lblTopSecondaryCount.Text = string.Format("{0:D2}:{1:D2}",
                    TopTPTimespan.Minutes,
                    TopTPTimespan.Seconds);
            }
            else
            {
                tmrTopSecondary.Stop();
                lblTopSecondaryAvailable.BackColor = Color.Green;
                int i = cmbTopSecondary.SelectedIndex;
                if (i == 0)
                {
                    picTopTP.Enabled = true;
                }
                else if (i == 1)
                {
                    picTopIgnite.Enabled = true;
                }
                else if (i == 2)
                {
                    picTopExhaust.Enabled = true;
                }
            }
        }

        private void picJungleFlash_Click(object sender, EventArgs e)
        {
            JungleFlashTimer = 300;
            if (chkJungleCD.Checked)
            {
                if (chkJungleIonian.Checked)
                {
                    JungleFlashTimer = 225;
                }
                else
                {
                    JungleFlashTimer = 255;
                }
            }
            else if (chkJungleIonian.Checked)
            {
                JungleFlashTimer = 270;
            }
            TimeSpan JungleFlashTimespan = TimeSpan.FromSeconds(JungleFlashTimer);
            lblJungleFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                JungleFlashTimespan.Minutes,
                JungleFlashTimespan.Seconds);
            tmrJungleFlash.Start();
            lblJungleFlashAvailable.BackColor = Color.Red;
            picJungleFlash.Enabled = false;
        }

        private void tmrJungleFlash_Tick(object sender, EventArgs e)
        {
            if (JungleFlashTimer > 0)
            {
                JungleFlashTimer -= 1;
                TimeSpan JungleFlashTimespan = TimeSpan.FromSeconds(JungleFlashTimer);
                lblJungleFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                    JungleFlashTimespan.Minutes,
                    JungleFlashTimespan.Seconds);
            }
            else
            {
                tmrJungleFlash.Stop();
                lblJungleFlashAvailable.BackColor = Color.Green;
                picTopFlash.Enabled = true;
            }
        }

        private void picMidFlash_Click(object sender, EventArgs e)
        {
            MidFlashTimer = 300;
            if (chkMidCD.Checked)
            {
                if (chkMidIonian.Checked)
                {
                    MidFlashTimer = 225;
                }
                else
                {
                    MidFlashTimer = 255;
                }
            }
            else if (chkMidIonian.Checked)
            {
                MidFlashTimer = 270;
            }
            TimeSpan MidFlashTimespan = TimeSpan.FromSeconds(MidFlashTimer);
            lblMidFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                MidFlashTimespan.Minutes,
                MidFlashTimespan.Seconds);
            tmrMidFlash.Start();
            lblMidFlashAvailable.BackColor = Color.Red;
            picMidFlash.Enabled = false;
        }

        private void tmrMidFlash_Tick(object sender, EventArgs e)
        {
            if (MidFlashTimer > 0)
            {
                MidFlashTimer -= 1;
                TimeSpan MidFlashTimespan = TimeSpan.FromSeconds(MidFlashTimer);
                lblMidFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                    MidFlashTimespan.Minutes,
                    MidFlashTimespan.Seconds);
            }
            else
            {
                tmrMidFlash.Stop();
                lblMidFlashAvailable.BackColor = Color.Green;
                picMidFlash.Enabled = true;
            }
        }

        private void picMidBarrier_Click(object sender, EventArgs e)
        {
            MidSecondaryTimer = 180;
            if (chkMidCD.Checked)
            {
                if (chkMidIonian.Checked)
                {
                    MidSecondaryTimer = 135;
                }
                else
                {
                    MidSecondaryTimer = 153;
                }
            }
            else if (chkMidIonian.Checked)
            {
                MidSecondaryTimer = 162;
            }
            picMidBarrier.Enabled = false;
            HandleMidSecondary();
        }

        private void picMidIgnite_Click(object sender, EventArgs e)
        {
            MidSecondaryTimer = 210;
            if (chkMidCD.Checked)
            {
                if (chkMidIonian.Checked)
                {
                    MidSecondaryTimer = 157.5;
                }
                else
                {
                    MidSecondaryTimer = 178.5;
                }
            }
            else if (chkMidIonian.Checked)
            {
                MidSecondaryTimer = 189;
            }
            picMidIgnite.Enabled = false;
            HandleMidSecondary();
        }

        private void picMidGhost_Click(object sender, EventArgs e)
        {
            MidSecondaryTimer = 180;
            if (chkMidCD.Checked)
            {
                if (chkMidIonian.Checked)
                {
                    MidSecondaryTimer = 135;
                }
                else
                {
                    MidSecondaryTimer = 153;
                }
            }
            else if (chkMidIonian.Checked)
            {
                MidSecondaryTimer = 162;
            }
            picMidGhost.Enabled = false;
            HandleMidSecondary();
        }

        private void picMidExhaust_Click(object sender, EventArgs e)
        {
            MidSecondaryTimer = 210;
            if (chkMidCD.Checked)
            {
                if (chkMidIonian.Checked)
                {
                    MidSecondaryTimer = 157.5;
                }
                else
                {
                    MidSecondaryTimer = 178.5;
                }
            }
            else if (chkMidIonian.Checked)
            {
                MidSecondaryTimer = 189;
            }
            picMidExhaust.Enabled = false;
            HandleMidSecondary();
        }

        private void picMidTP_Click(object sender, EventArgs e)
        {
            MidSecondaryTimer = 300;
            if (chkMidCD.Checked)
            {
                if (chkMidIonian.Checked)
                {
                    MidSecondaryTimer = 225;
                }
                else
                {
                    MidSecondaryTimer = 255;
                }
            }
            else if (chkMidIonian.Checked)
            {
                MidSecondaryTimer = 270;
            }
            picMidTP.Enabled = false;
            HandleMidSecondary();
        }

        private void HandleMidSecondary()
        {
            TimeSpan MidTPTimespan = TimeSpan.FromSeconds(MidSecondaryTimer);
            lblMidSecondaryCount.Text = string.Format("{0:D2}:{1:D2}",
                MidTPTimespan.Minutes,
                MidTPTimespan.Seconds);
            tmrMidSecondary.Start();
            lblMidSecondaryAvailable.BackColor = Color.Red;
        }

        private void tmrMidSecondary_Tick(object sender, EventArgs e)
        {
            if (MidSecondaryTimer > 0)
            {
                MidSecondaryTimer -= 1;
                TimeSpan MidTPTimespan = TimeSpan.FromSeconds(MidSecondaryTimer);
                lblMidSecondaryCount.Text = string.Format("{0:D2}:{1:D2}",
                    MidTPTimespan.Minutes,
                    MidTPTimespan.Seconds);
            }
            else
            {
                tmrMidSecondary.Stop();
                lblMidSecondaryAvailable.BackColor = Color.Green;
                int i = cmbMidSecondary.SelectedIndex;
                if (i == 0)
                {
                    picMidBarrier.Enabled = true;
                }
                else if (i == 1)
                {
                    picMidTP.Enabled = true;
                }
                else if (i == 2)
                {
                    picMidIgnite.Enabled = true;
                }
                else if (i == 3)
                {
                    picMidExhaust.Enabled = true;
                }
                else if (i == 4)
                {
                    picMidGhost.Enabled = true;
                }
            }
        }

        private void picADCFlash_Click(object sender, EventArgs e)
        {
            ADCFlashTimer = 300;
            if (chkADCCD.Checked)
            {
                if (chkADCIonian.Checked)
                {
                    ADCFlashTimer = 225;
                }
                else
                {
                    ADCFlashTimer = 255;
                }
            }
            else if (chkADCIonian.Checked)
            {
                ADCFlashTimer = 270;
            }
            TimeSpan ADCFlashTimespan = TimeSpan.FromSeconds(ADCFlashTimer);
            lblADCFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                ADCFlashTimespan.Minutes,
                ADCFlashTimespan.Seconds);
            tmrADCFlash.Start();
            lblADCFlashAvailable.BackColor = Color.Red;
            picADCFlash.Enabled = false;
        }

        private void tmrADCFlash_Tick(object sender, EventArgs e)
        {
            if (ADCFlashTimer > 0)
            {
                ADCFlashTimer -= 1;
                TimeSpan ADCFlashTimespan = TimeSpan.FromSeconds(ADCFlashTimer);
                lblADCFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                    ADCFlashTimespan.Minutes,
                    ADCFlashTimespan.Seconds);
            }
            else
            {
                tmrADCFlash.Stop();
                lblADCFlashAvailable.BackColor = Color.Green;
                picADCFlash.Enabled = true;
            }
        }

        private void picSupportFlash_Click(object sender, EventArgs e)
        {
            SupportFlashTimer = 300;
            if (chkSupportCD.Checked)
            {
                if (chkSupportIonian.Checked)
                {
                    SupportFlashTimer = 225;
                }
                else
                {
                    SupportFlashTimer = 255;
                }
            }
            else if (chkSupportIonian.Checked)
            {
                SupportFlashTimer = 270;
            }
            TimeSpan SupportFlashTimespan = TimeSpan.FromSeconds(SupportFlashTimer);
            lblSupportFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                SupportFlashTimespan.Minutes,
                SupportFlashTimespan.Seconds);
            tmrSupportFlash.Start();
            lblSupportFlashAvailable.BackColor = Color.Red;
            picSupportFlash.Enabled = false;
        }

        private void tmrSupportFlash_Tick(object sender, EventArgs e)
        {
            if (SupportFlashTimer > 0)
            {
                SupportFlashTimer -= 1;
                TimeSpan SupportFlashTimespan = TimeSpan.FromSeconds(SupportFlashTimer);
                lblSupportFlashCount.Text = string.Format("{0:D2}:{1:D2}",
                    SupportFlashTimespan.Minutes,
                    SupportFlashTimespan.Seconds);
            }
            else
            {
                tmrSupportFlash.Stop();
                lblSupportFlashAvailable.BackColor = Color.Green;
                picSupportFlash.Enabled = true;
            }
        }

        private void picADCHeal_Click(object sender, EventArgs e)
        {
            ADCSecondaryTimer = 240;
            if (chkADCCD.Checked)
            {
                if (chkADCIonian.Checked)
                {
                    ADCSecondaryTimer = 180;
                }
                else
                {
                    ADCSecondaryTimer = 204;
                }
            }
            else if (chkADCIonian.Checked)
            {
                ADCSecondaryTimer = 216;
            }
            picADCHeal.Enabled = false;
            HandleADCSecondary();
        }

        private void picADCIgnite_Click(object sender, EventArgs e)
        {
            ADCSecondaryTimer = 210;
            if (chkADCCD.Checked)
            {
                if (chkADCIonian.Checked)
                {
                    ADCSecondaryTimer = 157.5;
                }
                else
                {
                    ADCSecondaryTimer = 178.5;
                }
            }
            else if (chkADCIonian.Checked)
            {
                ADCSecondaryTimer = 189;
            }
            picADCIgnite.Enabled = false;
            HandleADCSecondary();
        }

        private void picADCExhaust_Click(object sender, EventArgs e)
        {
            ADCSecondaryTimer = 210;
            if (chkADCCD.Checked)
            {
                if (chkADCIonian.Checked)
                {
                    ADCSecondaryTimer = 157.5;
                }
                else
                {
                    ADCSecondaryTimer = 178.5;
                }
            }
            else if (chkADCIonian.Checked)
            {
                ADCSecondaryTimer = 189;
            }
            picADCExhaust.Enabled = false;
            HandleADCSecondary();
        }

        private void HandleADCSecondary()
        {
            TimeSpan ADCSecondaryTimespan = TimeSpan.FromSeconds(ADCSecondaryTimer);
            lblADCSecondaryCount.Text = string.Format("{0:D2}:{1:D2}",
                ADCSecondaryTimespan.Minutes,
                ADCSecondaryTimespan.Seconds);
            tmrADCSecondary.Start();
            lblADCSecondaryAvailable.BackColor = Color.Red;
        }
        private void tmrADCSecondary_Tick(object sender, EventArgs e)
        {
            if (ADCSecondaryTimer > 0)
            {
                ADCSecondaryTimer -= 1;
                TimeSpan ADCSecondaryTimespan = TimeSpan.FromSeconds(ADCSecondaryTimer);
                lblADCSecondaryCount.Text = string.Format("{0:D2}:{1:D2}",
                    ADCSecondaryTimespan.Minutes,
                    ADCSecondaryTimespan.Seconds);
            }
            else
            {
                tmrADCSecondary.Stop();
                lblADCSecondaryAvailable.BackColor = Color.Green;
                int i = cmbADCSecondary.SelectedIndex;
                if (i == 0)
                {
                    picADCHeal.Enabled = true;
                }
                else if (i == 1)
                {
                    picADCIgnite.Enabled = true;
                }
                else if (i == 2)
                {
                    picADCExhaust.Enabled = true;
                }
            }
        }

        private void picSupportExhaust_Click(object sender, EventArgs e)
        {
            SupportSecondaryTimer = 210;
            if (chkSupportCD.Checked)
            {
                if (chkSupportIonian.Checked)
                {
                    SupportSecondaryTimer = 157.5;
                }
                else
                {
                    SupportSecondaryTimer = 178.5;
                }
            }
            else if (chkSupportIonian.Checked)
            {
                SupportSecondaryTimer = 189;
            }
            picSupportExhaust.Enabled = false;
            HandleSupportSecondary();
        }

        private void picSupportIgnite_Click(object sender, EventArgs e)
        {
            SupportSecondaryTimer = 210;
            if (chkSupportCD.Checked)
            {
                if (chkSupportIonian.Checked)
                {
                    SupportSecondaryTimer = 157.5;
                }
                else
                {
                    SupportSecondaryTimer = 178.5;
                }
            }
            else if (chkSupportIonian.Checked)
            {
                SupportSecondaryTimer = 189;
            }
            picSupportIgnite.Enabled = false;
            HandleSupportSecondary();
        }

        private void HandleSupportSecondary()
        {
            TimeSpan SupportExhaustTimespan = TimeSpan.FromSeconds(SupportSecondaryTimer);
            lblSupportSecondaryCount.Text = string.Format("{0:D2}:{1:D2}",
                SupportExhaustTimespan.Minutes,
                SupportExhaustTimespan.Seconds);
            tmrSupportSecondary.Start();
            lblSupportSecondaryAvailable.BackColor = Color.Red;
        }
        private void tmrSupportExhaust_Tick(object sender, EventArgs e)
        {
            if (SupportSecondaryTimer > 0)
            {
                SupportSecondaryTimer -= 1;
                TimeSpan SupportExhaustTimespan = TimeSpan.FromSeconds(SupportSecondaryTimer);
                lblSupportSecondaryCount.Text = string.Format("{0:D2}:{1:D2}",
                    SupportExhaustTimespan.Minutes,
                    SupportExhaustTimespan.Seconds);
            }
            else
            {
                tmrSupportSecondary.Stop();
                lblSupportSecondaryAvailable.BackColor = Color.Green;
                int i = cmbSupportSecondary.SelectedIndex;
                if (i == 0)
                {
                    picSupportExhaust.Enabled = true;
                }
                else if (i == 1)
                {
                    picSupportIgnite.Enabled = true;
                }
            }
        }

        private void cmbMidSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbMidSecondary.SelectedIndex;
            if (i == 0)
            {
                picMidBarrier.BringToFront();
                picMidBarrier.Enabled = true;
                picMidTP.Enabled = false;
                picMidIgnite.Enabled = false;
                picMidExhaust.Enabled = false;
                picMidGhost.Enabled = false;
            }
            else if (i == 1)
            {
                picMidTP.BringToFront();
                picMidTP.Enabled = true;
                picMidBarrier.Enabled = false;
                picMidIgnite.Enabled = false;
                picMidExhaust.Enabled = false;
                picMidGhost.Enabled = false;
            }
            else if (i == 2)
            {
                picMidIgnite.BringToFront();
                picMidBarrier.Enabled = false;
                picMidTP.Enabled = false;
                picMidIgnite.Enabled = true;
                picMidExhaust.Enabled = false;
                picMidGhost.Enabled = false;
            }
            else if (i == 3)
            {
                picMidExhaust.BringToFront();
                picMidBarrier.Enabled = false;
                picMidTP.Enabled = false;
                picMidIgnite.Enabled = false;
                picMidExhaust.Enabled = true;
                picMidGhost.Enabled = false;
            }
            else if (i == 4)
            {
                picMidGhost.BringToFront();
                picMidBarrier.Enabled = false;
                picMidTP.Enabled = false;
                picMidIgnite.Enabled = false;
                picMidExhaust.Enabled = false;
                picMidGhost.Enabled = true;
            }
        }

        private void cmbTopSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbTopSecondary.SelectedIndex;
            if (i == 0)
            {
                picTopTP.BringToFront();
                picTopTP.Enabled = true;
                picTopIgnite.Enabled = false;
                picTopExhaust.Enabled = false;
            }
            else if (i == 1)
            {
                picTopIgnite.BringToFront();
                picTopTP.Enabled = false;
                picTopIgnite.Enabled = true;
                picTopExhaust.Enabled = false;
            }
            else if (i == 2)
            {
                picTopExhaust.BringToFront();
                picTopTP.Enabled = false;
                picTopIgnite.Enabled = false;
                picTopExhaust.Enabled = true;
            }

        }

        private void cmbADCSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbADCSecondary.SelectedIndex;
            if (i == 0)
            {
                picADCHeal.BringToFront();
                picADCHeal.Enabled = true;
                picADCIgnite.Enabled = false;
                picADCExhaust.Enabled = false;
            }
            else if (i == 1)
            {
                picADCIgnite.BringToFront();
                picADCHeal.Enabled = false;
                picADCIgnite.Enabled = true;
                picADCExhaust.Enabled = false;
            }
            else if (i == 2)
            {
                picADCExhaust.BringToFront();
                picADCHeal.Enabled = false;
                picADCIgnite.Enabled = false;
                picADCExhaust.Enabled = true;
            }
        }

        private void cmbSupportSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbSupportSecondary.SelectedIndex;
            if (i == 0)
            {
                picSupportExhaust.BringToFront();
                picSupportIgnite.Enabled = false;
                picSupportExhaust.Enabled = true;
            }
            else if (i == 1)
            {
                picSupportIgnite.BringToFront();
                picSupportIgnite.Enabled = true;
                picSupportExhaust.Enabled = false;
            }
        }
    }
}
