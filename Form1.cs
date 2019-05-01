using System;
using System.Windows.Forms;

namespace BattleShip_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            //first thing I need to do is set the battleship images visible
            ViewAll();
            
            //prompt user to click ship
            Output.AppendText("Place the ships by click on the ship and then the respective box\n");

            //start game






        }

        //function to set ships
        public void ViewAll()
        {
            //show ships
            Carrier.Visible = true;
            Battleship.Visible = true;
            Cruiser.Visible = true;
            Submarine.Visible = true;
            Destroyer.Visible = true;
            //show labels
            A_Label.Visible = true;
            B_Label.Visible = true;
            C_Label.Visible = true;
            D_Label.Visible = true;
            E_Label.Visible = true;
            F_Label.Visible = true;
            G_Label.Visible = true;
            H_Label.Visible = true;
            I_Label.Visible = true;
            J_Label.Visible = true;

            Label_1.Visible = true;
            Label_2.Visible = true;
            Label_3.Visible = true;
            Label_4.Visible = true;
            Label_5.Visible = true;
            Label_6.Visible = true;
            Label_7.Visible = true;
            Label_8.Visible = true;
            Label_9.Visible = true;
            Label_10.Visible = true;
            //show buttons
            A1.Visible = true;
            A2.Visible = true;
            A3.Visible = true;
            A4.Visible = true;
            A5.Visible = true;
            A6.Visible = true;
            A7.Visible = true;
            A8.Visible = true;
            A8.Visible = true;
            A9.Visible = true;
            A10.Visible = true;
            B1.Visible = true;
            B2.Visible = true;
            B3.Visible = true;
            B4.Visible = true;
            B5.Visible = true;
            B6.Visible = true;
            B7.Visible = true;
            B8.Visible = true;
            B9.Visible = true;
            B10.Visible = true;
            C1.Visible = true;
            C2.Visible = true;
            C3.Visible = true;
            C4.Visible = true;
            C5.Visible = true;
            C6.Visible = true;
            C7.Visible = true;
            C8.Visible = true;
            C9.Visible = true;
            C10.Visible = true;
            D1.Visible = true;
            D2.Visible = true;
            D3.Visible = true;
            D4.Visible = true;
            D5.Visible = true;
            D6.Visible = true;
            D7.Visible = true;
            D8.Visible = true;
            D9.Visible = true;
            D10.Visible = true;
            E1.Visible = true;
            E2.Visible = true;
            E3.Visible = true;
            E4.Visible = true;
            E5.Visible = true;
            E6.Visible = true;
            E7.Visible = true;
            E8.Visible = true;
            E9.Visible = true;
            E10.Visible = true;
            F1.Visible = true;
            F2.Visible = true;
            F3.Visible = true;
            F4.Visible = true;
            F5.Visible = true;
            F6.Visible = true;
            F7.Visible = true;
            F8.Visible = true;
            F9.Visible = true;
            F10.Visible = true;
            G1.Visible = true;
            G2.Visible = true;
            G3.Visible = true;
            G4.Visible = true;
            G5.Visible = true;
            G6.Visible = true;
            G7.Visible = true;
            G8.Visible = true;
            G9.Visible = true;
            G10.Visible = true;
            H1.Visible = true;
            H2.Visible = true;
            H3.Visible = true;
            H4.Visible = true;
            H5.Visible = true;
            H6.Visible = true;
            H7.Visible = true;
            H8.Visible = true;
            H9.Visible = true;
            H10.Visible = true;
            I1.Visible = true;
            I2.Visible = true;
            I3.Visible = true;
            I4.Visible = true;
            I5.Visible = true;
            I6.Visible = true;
            I7.Visible = true;
            I8.Visible = true;
            I9.Visible = true;
            I10.Visible = true;
            J1.Visible = true;
            J2.Visible = true;
            J3.Visible = true;
            J4.Visible = true;
            J5.Visible = true;
            J6.Visible = true;
            J7.Visible = true;
            J8.Visible = true;
            J9.Visible = true;
            J10.Visible = true;
        }

        private void A_Label_Click(object sender, EventArgs e)
        {

        }

        //change later to be more descript
        private enum PlayerHitStaus
        {
            //this is the same as 1
            //PlayerHitStaus.hit == 1
            hit = 1,
            //I could use this enum to place a x mark over the hit markers

        }

        //this function is working, Yay!
        private void Destroyer_MouseHover(object sender, EventArgs e)
        {
            Output.Clear();
            Output.AppendText("Hover is working. Coninute to use in buttons");
        }

        //placing ships
        #region Ship Functions
        private void Destroyer_Click(object sender, EventArgs e)
        {
            //Show what ship is selected
            Output.Clear();
            Output.AppendText("Destroyer Selected\n");
            Output.AppendText("\nLeft edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30,30 else return to previous position
            Destroyer.Location = new System.Drawing.Point(15, 15);
            Cruiser.Location = new System.Drawing.Point(330, 100);
            Submarine.Location = new System.Drawing.Point(315, 150);
            Battleship.Location = new System.Drawing.Point(280, 250);
            Cruiser.Location = new System.Drawing.Point(230, 330);

            //how would I go about rotating it
            //I could have a variable and a button that is use to change the orientation of the ship
            //enum maybe?
            //move the ship image to the middle of the screen to show the orientation it will be placed in



            //how would i take the button clicked output and have it as the place to place it.
            //also how would I go about check it if it is a valid location
        }

        private void Cruiser_Click(object sender, EventArgs e)
        {
            Output.Clear();
            Output.AppendText("Destroyer Selected\n");
            Output.AppendText("\nLeft edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30,30 else return to previous position
            Destroyer.Location = new System.Drawing.Point(370, 35);
            Cruiser.Location = new System.Drawing.Point(15, 15);
            Submarine.Location = new System.Drawing.Point(315, 150);
            Battleship.Location = new System.Drawing.Point(280, 250);
            Cruiser.Location = new System.Drawing.Point(230, 330);

        }

        private void Submarine_Click(object sender, EventArgs e)
        {
            Output.Clear();
            Output.AppendText("Destroyer Selected\n");
            Output.AppendText("\nLeft edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30,30 else return to previous position
            Destroyer.Location = new System.Drawing.Point(370, 35);
            Cruiser.Location = new System.Drawing.Point(330, 100);
            Submarine.Location = new System.Drawing.Point(15, 15);
            Battleship.Location = new System.Drawing.Point(280, 250);
            Cruiser.Location = new System.Drawing.Point(230, 330);
        }

        private void Battleship_Click(object sender, EventArgs e)
        {
            Output.Clear();
            Output.AppendText("Destroyer Selected\n");
            Output.AppendText("\nLeft edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30,30 else return to previous position
            Destroyer.Location = new System.Drawing.Point(370, 35);
            Cruiser.Location = new System.Drawing.Point(330, 100);
            Submarine.Location = new System.Drawing.Point(315, 150);
            Battleship.Location = new System.Drawing.Point(15, 15);
            Cruiser.Location = new System.Drawing.Point(230, 330);
        }

        private void Carrier_Click(object sender, EventArgs e)
        {
            //clicking this should allow for the ships to be placed. But this should work the same for every ship
            //Call a funciton to place everything
            Output.Clear();
            Output.AppendText("Destroyer Selected\n");
            Output.AppendText("\nLeft edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30,30 else return to previous position
            Destroyer.Location = new System.Drawing.Point(370, 35);
            Cruiser.Location = new System.Drawing.Point(330, 100);
            Submarine.Location = new System.Drawing.Point(315, 150);
            Battleship.Location = new System.Drawing.Point(280, 250);
            Carrier.Location = new System.Drawing.Point(15, 15);

        }



        #endregion



        //for buttons I want the screen to show where each ship is placed
        //maybe move the image over the button and disable the button so it cannot be placed
        #region Button Funcitons

        #region A Row

        private void A1_Click(object sender, EventArgs e)
        {

        }
        private void A2_Click(object sender, EventArgs e)
        {

        }
        private void A3_Click(object sender, EventArgs e)
        {

        }
        private void A4_Click(object sender, EventArgs e)
        {

        }
        private void A5_Click(object sender, EventArgs e)
        {

        }
        private void A6_Click(object sender, EventArgs e)
        {

        }
        private void A7_Click(object sender, EventArgs e)
        {

        }
        private void A8_Click(object sender, EventArgs e)
        {

        }
        private void A9_Click(object sender, EventArgs e)
        {

        }
        private void A10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region B Row

        private void B1_Click(object sender, EventArgs e)
        {

        }
        private void B2_Click(object sender, EventArgs e)
        {

        }
        private void B3_Click(object sender, EventArgs e)
        {

        }
        private void B4_Click(object sender, EventArgs e)
        {

        }
        private void B5_Click(object sender, EventArgs e)
        {

        }
        private void B6_Click(object sender, EventArgs e)
        {

        }
        private void B7_Click(object sender, EventArgs e)
        {

        }
        private void B8_Click(object sender, EventArgs e)
        {

        }
        private void B9_Click(object sender, EventArgs e)
        {

        }
        private void B10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region C Row

        private void C1_Click(object sender, EventArgs e)
        {

        }
        private void C2_Click(object sender, EventArgs e)
        {

        }
        private void C3_Click(object sender, EventArgs e)
        {

        }

        private void C4_Click(object sender, EventArgs e)
        {

        }
        private void C5_Click(object sender, EventArgs e)
        {

        }
        private void C6_Click(object sender, EventArgs e)
        {

        }
        private void C7_Click(object sender, EventArgs e)
        {

        }
        private void C8_Click(object sender, EventArgs e)
        {

        }
        private void C9_Click(object sender, EventArgs e)
        {

        }
        private void C10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region D Row

        private void D1_Click(object sender, EventArgs e)
        {

        }
        private void D2_Click(object sender, EventArgs e)
        {

        }
        private void D3_Click(object sender, EventArgs e)
        {

        }
        private void D4_Click(object sender, EventArgs e)
        {

        }
        private void D5_Click(object sender, EventArgs e)
        {

        }
        private void D6_Click(object sender, EventArgs e)
        {

        }
        private void D7_Click(object sender, EventArgs e)
        {

        }
        private void D8_Click(object sender, EventArgs e)
        {

        }
        private void D9_Click(object sender, EventArgs e)
        {

        }
        private void D10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region E Row

        private void E1_Click(object sender, EventArgs e)
        {

        }
        private void E2_Click(object sender, EventArgs e)
        {

        }
        private void E3_Click(object sender, EventArgs e)
        {

        }
        private void E4_Click(object sender, EventArgs e)
        {

        }
        private void E5_Click(object sender, EventArgs e)
        {

        }
        private void E6_Click(object sender, EventArgs e)
        {

        }
        private void E7_Click(object sender, EventArgs e)
        {

        }
        private void E8_Click(object sender, EventArgs e)
        {

        }
        private void E9_Click(object sender, EventArgs e)
        {

        }
        private void E10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region F Row

        private void F1_Click(object sender, EventArgs e)
        {

        }
        private void F2_Click(object sender, EventArgs e)
        {

        }
        private void F3_Click(object sender, EventArgs e)
        {

        }
        private void F4_Click(object sender, EventArgs e)
        {

        }
        private void F5_Click(object sender, EventArgs e)
        {

        }
        private void F6_Click(object sender, EventArgs e)
        {

        }
        private void F7_Click(object sender, EventArgs e)
        {

        }
        private void F8_Click(object sender, EventArgs e)
        {

        }
        private void F9_Click(object sender, EventArgs e)
        {

        }
        private void F10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region G Row

        private void G1_Click(object sender, EventArgs e)
        {

        }
        private void G2_Click(object sender, EventArgs e)
        {

        }
        private void G3_Click(object sender, EventArgs e)
        {

        }
        private void G4_Click(object sender, EventArgs e)
        {

        }
        private void G5_Click(object sender, EventArgs e)
        {

        }
        private void G6_Click(object sender, EventArgs e)
        {

        }
        private void G7_Click(object sender, EventArgs e)
        {

        }
        private void G8_Click(object sender, EventArgs e)
        {

        }
        private void G9_Click(object sender, EventArgs e)
        {

        }
        private void G10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region H Row

        private void H1_Click(object sender, EventArgs e)
        {

        }
        private void H2_Click(object sender, EventArgs e)
        {

        }
        private void H3_Click(object sender, EventArgs e)
        {

        }
        private void H4_Click(object sender, EventArgs e)
        {

        }
        private void H5_Click(object sender, EventArgs e)
        {

        }
        private void H6_Click(object sender, EventArgs e)
        {

        }
        private void H7_Click(object sender, EventArgs e)
        {

        }
        private void H8_Click(object sender, EventArgs e)
        {

        }
        private void H9_Click(object sender, EventArgs e)
        {

        }
        private void H10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region I Row

        private void I1_Click(object sender, EventArgs e)
        {

        }
        private void I2_Click(object sender, EventArgs e)
        {

        }
        private void I3_Click(object sender, EventArgs e)
        {

        }
        private void I4_Click(object sender, EventArgs e)
        {

        }
        private void I5_Click(object sender, EventArgs e)
        {

        }
        private void I6_Click(object sender, EventArgs e)
        {

        }
        private void I7_Click(object sender, EventArgs e)
        {

        }
        private void I8_Click(object sender, EventArgs e)
        {

        }
        private void I9_Click(object sender, EventArgs e)
        {

        }
        private void I10_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region J Row

        private void J1_Click(object sender, EventArgs e)
        {

        }
        private void J2_Click(object sender, EventArgs e)
        {

        }
        private void J3_Click(object sender, EventArgs e)
        {

        }
        private void J4_Click(object sender, EventArgs e)
        {

        }
        private void J5_Click(object sender, EventArgs e)
        {

        }
        private void J6_Click(object sender, EventArgs e)
        {

        }
        private void J7_Click(object sender, EventArgs e)
        {

        }
        private void J8_Click(object sender, EventArgs e)
        {

        }
        private void J9_Click(object sender, EventArgs e)
        {

        }
        private void J10_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}
