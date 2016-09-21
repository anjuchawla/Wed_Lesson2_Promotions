/*
 * 
 * Name : Anju Chawla
 * Date: Septemeber 21, 2016
 * Purpose:The application allows a member to sign in, 
 * thereafter showing the promotions available. 
 * The member can choose one of the departments to 
 * see the promotion. Picture of a department can be shown.
 * The form can be printed.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wed_Lesson2_Promotions
{
    public partial class frmPromotions : Form
    {
        public frmPromotions()
        {
            InitializeComponent();
        }

        private void frmPromotions_Load(object sender, EventArgs e)
        {
            //default settings when form is loaded
            grpDepartment.Enabled = false;
            rtfWelcome.Visible = false;
            txtPromotion.Visible = false;
            chkImageVisible.Visible = false;
            picDepartment.Visible = false;

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //allow the memeber to sign in, hide the input details
            //display a welcome message and alllow the member to choose options
            rtfWelcome.Visible = true;
            rtfWelcome.Text = "Welcome " + txtName.Text +
                Environment.NewLine + "Member ID: " + mtbMemberId.Text;

            //hide the input controls
            lblName.Visible = false;
            txtName.Visible = false;
            lblMemberId.Visible = false;
            mtbMemberId.Visible = false;


            //enable the department names
            grpDepartment.Enabled = true;
            rdoClothing.Checked = false;
            chkImageVisible.Visible = true;
            //disable the sign in button
            btnSignIn.Enabled = false;

            //show promotion label
            txtPromotion.Visible = true;
        }

        private void rdoClothing_CheckedChanged(object sender, EventArgs e)
        {
            //show the promotion details for clothing
            txtPromotion.Text = "30% off clearance items";
            picDepartment.Image = Wed_Lesson2_Promotions.Properties.Resources.clothing;

        }

        private void rdoEquipment_CheckedChanged(object sender, EventArgs e)
        {
            //show the promotion details for equipment/accessories
            txtPromotion.Text = "30% off all equipment";
            picDepartment.Image = Properties.Resources.equipment;
        }

        private void rdoJuiceBar_CheckedChanged(object sender, EventArgs e)
        {
            //show the promotion details for juice bar
            txtPromotion.Text = "Free serving of WheatBerry shake";
            picDepartment.Image = Properties.Resources.juice;
        }

        private void rdoMembership_CheckedChanged(object sender, EventArgs e)
        {
            //show the promotion details for member
            txtPromotion.Text = "Free personal trainer for the first month";
            picDepartment.Image = Properties.Resources.member;

        }

        private void rdoTraining_CheckedChanged(object sender, EventArgs e)
        {
            //show the promotion details for personal training
            txtPromotion.Text = "3 free sessions with membership renewal";
            picDepartment.Image = Properties.Resources.training;
        }

        private void chkImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            //set the visibility of the department picture box
            picDepartment.Visible = chkImageVisible.Checked;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //print the form 
            printForm1.Print();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //terminate the application
            //Application.Exit();
            //close the form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //back to default start state
            Application.Restart();

        }
    }
}
