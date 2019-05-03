using System;
using System.Windows.Forms;

namespace BattleShip_FinalProject
{
    public partial class Form1 : Form
    {
        public Game PlayBattleShip { get; set; }
        public Player user { get; set; }
        public Player AI { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sernder, EventArgs e)
        {

        }

        public void Start_Click(object sernder, EventArgs e)
        {

            //prompt user to click ship
            
            Output.AppendText("Place the ships by click on the ship and then the respective box" + Environment.NewLine);
            user = new Player("User");
            AI = new Player("Computer");
            PlayBattleShip = new Game(user, AI);

            //Place Ships in order by Carrier ,  Battleship ,  Cruiser ,  Submarine ,  Destoryer          

            //first thing I need to do is set the battleship images visible
            Img_Carrier.Visible = true;
            Img_Carrier.Location = new System.Drawing.Point(15, 15);
            ShowGrid();




            //after the placing function move the carrier back to the origional location
        }

        public void ButtonPressed(int row, int column)
        {
            //every button is assigned a value 
            if (user.CarrierActive)
            { 
                if (user.PlaceCarrier(row, column, user))
                {
                    Output.Clear();
                    Output.AppendText(user.Carrier.Name + " has been placed successfully");
                }
                else
                {
                    Output.Clear();
                    Output.AppendText("Invalid Location. " + Environment.NewLine + user.Carrier.Name + " could not be placed.");
                }
            }

            if (user.BattleshipActive)
            {
                user.PlaceBattleShip(1, 1);
            }

            if (user.CruiserActive)
            {
                user.PlaceCruiser(1, 1);
            }

            if (user.SubmarinePlaced)
            {
                user.PlaceSubmarine(1, 1);
            }

            if (user.DestroyerPlaced)
            {
                user.PlaceDestroyer(1, 1);
            }
        }

        //function to set ships
        public void ShowGrid()
        {
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

        //this function is working ,  Yay!
        private void Destroyer_MouseHover(object sernder, EventArgs e)
        {
            Output.Clear();
            Output.AppendText("Hover is working. Coninute to use in buttons");
        }



        //placing ships
        #region Ship Functions
        private void Destroyer_Click(object sernder, EventArgs e)
        {
            //Show what ship is selected
            Output.Clear();
            Output.AppendText("Destroyer Selected" + Environment.NewLine);
            Output.AppendText(Environment.NewLine + "Left edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30 , 30 else return to previous position
            Img_Destroyer.Location = new System.Drawing.Point(15, 15);
            Img_Cruiser.Location = new System.Drawing.Point(330, 100);
            Img_Submarine.Location = new System.Drawing.Point(315, 150);
            Img_Battleship.Location = new System.Drawing.Point(280, 250);
            Img_Cruiser.Location = new System.Drawing.Point(230, 330);

            //ship has been selected




            //for orientation I should add to the column or row 




            //how would I go about rotating it
            //I could have a variable and a button that is use to change the orientation of the ship
            //enum maybe?
            //move the ship image to the middle of the screen to show the orientation it will be placed in



            //how would i take the button clicked output and have it as the place to place it.
            //also how would I go about check it if it is a valid location
        }

        private void Cruiser_Click(object sernder, EventArgs e)
        {
            Output.Clear();
            Output.AppendText("Destroyer Selected" + Environment.NewLine);
            Output.AppendText(Environment.NewLine + "Left edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30 , 30 else return to previous position
            Img_Destroyer.Location = new System.Drawing.Point(370, 35);
            Img_Cruiser.Location = new System.Drawing.Point(15, 15);
            Img_Submarine.Location = new System.Drawing.Point(315, 150);
            Img_Battleship.Location = new System.Drawing.Point(280, 250);
            Img_Cruiser.Location = new System.Drawing.Point(230, 330);

        }

        private void Submarine_Click(object sernder, EventArgs e)
        {
            Output.Clear();
            Output.AppendText("Destroyer Selected" + Environment.NewLine);
            Output.AppendText(Environment.NewLine + "Left edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30 , 30 else return to previous position
            Img_Destroyer.Location = new System.Drawing.Point(370, 35);
            Img_Cruiser.Location = new System.Drawing.Point(330, 100);
            Img_Submarine.Location = new System.Drawing.Point(15, 15);
            Img_Battleship.Location = new System.Drawing.Point(280, 250);
            Img_Cruiser.Location = new System.Drawing.Point(230, 330);
        }

        private void Battleship_Click(object sernder, EventArgs e)
        {
            Output.Clear();
            Output.AppendText("Destroyer Selected" + Environment.NewLine);
            Output.AppendText(Environment.NewLine + "Left edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30 , 30 else return to previous position
            Img_Destroyer.Location = new System.Drawing.Point(370, 35);
            Img_Cruiser.Location = new System.Drawing.Point(330, 100);
            Img_Submarine.Location = new System.Drawing.Point(315, 150);
            Img_Battleship.Location = new System.Drawing.Point(15, 15);
            Img_Cruiser.Location = new System.Drawing.Point(230, 330);
        }

        private void Carrier_Click(object sernder, EventArgs e)
        {
            //clicking this should allow for the ships to be placed. But this should work the same for every ship
            //Call a funciton to place everything
            Output.Clear();
            Output.AppendText("Destroyer Selected" + Environment.NewLine);
            Output.AppendText(Environment.NewLine + "Left edge is selected. Place the ship anywhere on the screen");
            //if selected move to 30 , 30 else return to previous position
            Img_Destroyer.Location = new System.Drawing.Point(370, 35);
            Img_Cruiser.Location = new System.Drawing.Point(330, 100);
            Img_Submarine.Location = new System.Drawing.Point(315, 150);
            Img_Battleship.Location = new System.Drawing.Point(280, 250);
            Img_Carrier.Location = new System.Drawing.Point(15, 15);

        }

        #endregion

        //for buttons I want the screen to show where each ship is placed
        //maybe move the image over the button and disable the button so it cannot be placed
        #region Button Funcitons

        #region A Row

        public void A1_Click(object sernder, EventArgs e) { ButtonPressed(1, 1); }



        public void A2_Click(object sernder, EventArgs e) { ButtonPressed(2, 1); }



        public void A3_Click(object sernder, EventArgs e) { ButtonPressed(3, 1); }



        public void A4_Click(object sernder, EventArgs e) { ButtonPressed(4, 1); }



        public void A5_Click(object sernder, EventArgs e) { ButtonPressed(5, 1); }



        public void A6_Click(object sernder, EventArgs e) { ButtonPressed(6, 1); }



        public void A7_Click(object sernder, EventArgs e) { ButtonPressed(7, 1); }



        public void A8_Click(object sernder, EventArgs e) { ButtonPressed(8, 1); }



        public void A9_Click(object sernder, EventArgs e) { ButtonPressed(9, 1); }



        public void A10_Click(object sernder, EventArgs e) { ButtonPressed(10, 1); }




        #endregion


        #region B Row

        public void B1_Click(object sernder, EventArgs e) { ButtonPressed(1, 2); }



        public void B2_Click(object sernder, EventArgs e) { ButtonPressed(2, 2); }



        public void B3_Click(object sernder, EventArgs e) { ButtonPressed(3, 2); }



        public void B4_Click(object sernder, EventArgs e) { ButtonPressed(4, 2); }



        public void B5_Click(object sernder, EventArgs e) { ButtonPressed(5, 2); }



        public void B6_Click(object sernder, EventArgs e) { ButtonPressed(6, 2); }



        public void B7_Click(object sernder, EventArgs e) { ButtonPressed(7, 2); }



        public void B8_Click(object sernder, EventArgs e) { ButtonPressed(8, 2); }



        public void B9_Click(object sernder, EventArgs e) { ButtonPressed(9, 2); }



        public void B10_Click(object sernder, EventArgs e) { ButtonPressed(10, 2); }




        #endregion


        #region C Row

        public void C1_Click(object sernder, EventArgs e) { ButtonPressed(1, 3); }



        public void C2_Click(object sernder, EventArgs e) { ButtonPressed(2, 3); }



        public void C3_Click(object sernder, EventArgs e) { ButtonPressed(3, 3); }




        public void C4_Click(object sernder, EventArgs e) { ButtonPressed(4, 3); }



        public void C5_Click(object sernder, EventArgs e) { ButtonPressed(5, 3); }



        public void C6_Click(object sernder, EventArgs e) { ButtonPressed(6, 3); }



        public void C7_Click(object sernder, EventArgs e) { ButtonPressed(7, 3); }



        public void C8_Click(object sernder, EventArgs e) { ButtonPressed(8, 3); }



        public void C9_Click(object sernder, EventArgs e) { ButtonPressed(9, 3); }



        public void C10_Click(object sernder, EventArgs e) { ButtonPressed(10, 3); }




        #endregion


        #region D Row

        public void D1_Click(object sernder, EventArgs e) { ButtonPressed(1, 4); }



        public void D2_Click(object sernder, EventArgs e) { ButtonPressed(2, 4); }



        public void D3_Click(object sernder, EventArgs e) { ButtonPressed(3, 4); }



        public void D4_Click(object sernder, EventArgs e) { ButtonPressed(4, 4); }



        public void D5_Click(object sernder, EventArgs e) { ButtonPressed(5, 4); }



        public void D6_Click(object sernder, EventArgs e) { ButtonPressed(6, 4); }



        public void D7_Click(object sernder, EventArgs e) { ButtonPressed(7, 4); }



        public void D8_Click(object sernder, EventArgs e) { ButtonPressed(8, 4); }



        public void D9_Click(object sernder, EventArgs e) { ButtonPressed(9, 4); }



        public void D10_Click(object sernder, EventArgs e) { ButtonPressed(10, 4); }




        #endregion


        #region E Row

        public void E1_Click(object sernder, EventArgs e) { ButtonPressed(1, 5); }



        public void E2_Click(object sernder, EventArgs e) { ButtonPressed(2, 5); }



        public void E3_Click(object sernder, EventArgs e) { ButtonPressed(3, 5); }



        public void E4_Click(object sernder, EventArgs e) { ButtonPressed(4, 5); }



        public void E5_Click(object sernder, EventArgs e) { ButtonPressed(5, 5); }



        public void E6_Click(object sernder, EventArgs e) { ButtonPressed(6, 5); }



        public void E7_Click(object sernder, EventArgs e) { ButtonPressed(7, 5); }



        public void E8_Click(object sernder, EventArgs e) { ButtonPressed(8, 5); }



        public void E9_Click(object sernder, EventArgs e) { ButtonPressed(9, 5); }



        public void E10_Click(object sernder, EventArgs e) { ButtonPressed(10, 5); }




        #endregion


        #region F Row

        public void F1_Click(object sernder, EventArgs e) { ButtonPressed(1, 6); }



        public void F2_Click(object sernder, EventArgs e) { ButtonPressed(2, 6); }



        public void F3_Click(object sernder, EventArgs e) { ButtonPressed(3, 6); }



        public void F4_Click(object sernder, EventArgs e) { ButtonPressed(4, 6); }



        public void F5_Click(object sernder, EventArgs e) { ButtonPressed(5, 6); }



        public void F6_Click(object sernder, EventArgs e) { ButtonPressed(6, 6); }



        public void F7_Click(object sernder, EventArgs e) { ButtonPressed(7, 6); }



        public void F8_Click(object sernder, EventArgs e) { ButtonPressed(8, 6); }



        public void F9_Click(object sernder, EventArgs e) { ButtonPressed(9, 6); }



        public void F10_Click(object sernder, EventArgs e) { ButtonPressed(10, 6); }




        #endregion


        #region G Row

        public void G1_Click(object sernder, EventArgs e) { ButtonPressed(1, 7); }



        public void G2_Click(object sernder, EventArgs e) { ButtonPressed(2, 7); }



        public void G3_Click(object sernder, EventArgs e) { ButtonPressed(3, 7); }



        public void G4_Click(object sernder, EventArgs e) { ButtonPressed(4, 7); }



        public void G5_Click(object sernder, EventArgs e) { ButtonPressed(5, 7); }



        public void G6_Click(object sernder, EventArgs e) { ButtonPressed(6, 7); }



        public void G7_Click(object sernder, EventArgs e) { ButtonPressed(7, 7); }



        public void G8_Click(object sernder, EventArgs e) { ButtonPressed(8, 7); }



        public void G9_Click(object sernder, EventArgs e) { ButtonPressed(9, 7); }



        public void G10_Click(object sernder, EventArgs e) { ButtonPressed(10, 7); }




        #endregion


        #region H Row

        public void H1_Click(object sernder, EventArgs e) { ButtonPressed(1, 8); }



        public void H2_Click(object sernder, EventArgs e) { ButtonPressed(2, 8); }



        public void H3_Click(object sernder, EventArgs e) { ButtonPressed(3, 8); }



        public void H4_Click(object sernder, EventArgs e) { ButtonPressed(4, 8); }



        public void H5_Click(object sernder, EventArgs e) { ButtonPressed(5, 8); }



        public void H6_Click(object sernder, EventArgs e) { ButtonPressed(6, 8); }



        public void H7_Click(object sernder, EventArgs e) { ButtonPressed(7, 8); }



        public void H8_Click(object sernder, EventArgs e) { ButtonPressed(8, 8); }



        public void H9_Click(object sernder, EventArgs e) { ButtonPressed(9, 8); }



        public void H10_Click(object sernder, EventArgs e) { ButtonPressed(10, 8); }




        #endregion


        #region I Row

        public void I1_Click(object sernder, EventArgs e) { ButtonPressed(1, 9); }



        public void I2_Click(object sernder, EventArgs e) { ButtonPressed(2, 9); }



        public void I3_Click(object sernder, EventArgs e) { ButtonPressed(3, 9); }



        public void I4_Click(object sernder, EventArgs e) { ButtonPressed(4, 9); }



        public void I5_Click(object sernder, EventArgs e) { ButtonPressed(5, 9); }



        public void I6_Click(object sernder, EventArgs e) { ButtonPressed(6, 9); }



        public void I7_Click(object sernder, EventArgs e) { ButtonPressed(7, 9); }



        public void I8_Click(object sernder, EventArgs e) { ButtonPressed(8, 9); }



        public void I9_Click(object sernder, EventArgs e) { ButtonPressed(9, 9); }



        public void I10_Click(object sernder, EventArgs e) { ButtonPressed(10, 9); }




        #endregion


        #region J Row

        public void J1_Click(object sernder, EventArgs e) { ButtonPressed(1, 10); }



        public void J2_Click(object sernder, EventArgs e) { ButtonPressed(2, 10); }



        public void J3_Click(object sernder, EventArgs e) { ButtonPressed(3, 10); }



        public void J4_Click(object sernder, EventArgs e) { ButtonPressed(4, 10); }



        public void J5_Click(object sernder, EventArgs e) { ButtonPressed(5, 10); }



        public void J6_Click(object sernder, EventArgs e) { ButtonPressed(6, 10); }



        public void J7_Click(object sernder, EventArgs e) { ButtonPressed(7, 10); }



        public void J8_Click(object sernder, EventArgs e) { ButtonPressed(8, 10); }



        public void J9_Click(object sernder, EventArgs e) { ButtonPressed(9, 10); }



        public void J10_Click(object sernder, EventArgs e) { ButtonPressed(10, 10); }




        #endregion

        #endregion



    }
}
