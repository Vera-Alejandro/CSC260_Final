using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            //first thing I need to do is set the battleship images visible
            ViewAll();

            //create the two firing boards
            GameBoard PlayerBoard = new GameBoard();
            GameBoard FiringBoard = new GameBoard();

            //create player and oponent's ships
            //*I might not have to create these instances -- just use the place funciton*
            Carrier PCarrier = new Carrier();
            Carrier OCarrier = new Carrier();
            Battleship PBattleship = new Battleship();
            Battleship OBattlehsip = new Battleship();
            Cruiser PCruiser = new Cruiser();
            Cruiser OCruiser = new Cruiser();
            Submarine PSub = new Submarine();
            Submarine OSub = new Submarine();
            Destroyer PDestoyer = new Destroyer();
            Destroyer ODestroyer = new Destroyer();



        }

        private void Carrier_Click(object sender, EventArgs e)
        {
            //clicking this should allow for the ships to be placed. But this should work the same for every ship
            //Call a funciton to place everything 
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
    }
}
