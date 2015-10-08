/*
 * Created by: Nicholas  Ellul
 * Created on: OCT-8-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-07 
 * This program animates a walking man
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WalkingMan307

{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

   
       private void btnRun_Click(object sender, EventArgs e)
        {
           
                int loopCounter = 0;

            do
            {

                if (loopCounter == 0)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk2;
                }
                else if (loopCounter == 1)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk3;
                }
                else if (loopCounter == 2)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk4;
                }
                else if (loopCounter == 3)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk5;
                }
                else if (loopCounter == 4)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk6;
                }
                else if (loopCounter == 5)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk7;
                }
                else if (loopCounter == 6)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk8;
                }
                else if (loopCounter == 7)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk9;
                }
                else if (loopCounter == 8)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk10;
                }
                else if (loopCounter == 9)
                {
                    this.picMan.Image = WalkingMan307.Properties.Resources.walk1;
                }

                loopCounter = loopCounter + 1;

                // pause
               
                this.picMan.Location = new Point(this.picMan.Location.X - 5, this.picMan.Location.Y);
                this.Refresh();
                Thread.Sleep(100);

                if (loopCounter == 10) {
                    loopCounter = 0;
                } 

                } while (loopCounter < 10);
            }

       
    }

    }


