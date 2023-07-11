using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EditUI : Form
    {
        private Facade _fc;
        public EditUI(Facade fc)
        {
            InitializeComponent();
            _fc = fc;
            
        }

        private void EditUI_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 2);
            gra.DrawLine(blackPen, 1, 1, 310, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int blackNoteDuration = int.Parse(tBlackNote.Text);
                int beatDuration = int.Parse(tDuration.Text);
                AddBeat(blackNoteDuration, beatDuration);
            } catch (Exception ex)
            {

            }

            
            
        }

        private void AddBeat(int blackNote, int beatDuration)
        {
            _fc.AddBeat(blackNote, beatDuration);
        }

        private void DeleteBeat(int beatNumber)
        {
            _fc.DeleteBeat(beatNumber);
        }

        private void btnDeleteBeat_Click(object sender, EventArgs e)
        {
            try
            {
                int beatNumber = int.Parse(tBeatNumber.Text);
                DeleteBeat(beatNumber);
            } catch (Exception ex)
            {

            }
            
        }

        private void AddNote(byte pitch, int typeNote, int deltaTime, int beatNumber)
        {
            _fc.AddNote(pitch, typeNote, deltaTime, beatNumber);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {

            try
            {
                int intPitch = int.Parse(tPitch.Text);

                if (intPitch >= 0 && intPitch <= 127)
                {
                    byte[] bytes = BitConverter.GetBytes(intPitch);
                    byte bytePitch = bytes[0];

                    int note = cbNote.SelectedIndex;
                    int time = int.Parse(tTime.Text);



                    int beatNumber = int.Parse(tBeatNumber2.Text);

                    if (beatNumber - 1 < _fc.QuantityBeats() && beatNumber > 0)
                    {
                        if (time >= 0)
                        {
                            AddNote(bytePitch, note, time, beatNumber);
                        }
                        
                    }
   
                }
            } catch (Exception ex)
            {

            }

            

            
        }

        private void DeleteNote(int noteNumber, int beatNumber)
        {
            _fc.DeleteNote(noteNumber, beatNumber);
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            try
            {
                int beatNumber = int.Parse(tBeatNumber2.Text);
                int noteNumber = int.Parse(tNoteNumber.Text);
                DeleteNote(noteNumber, beatNumber);

            } catch (Exception ex)
            {

            }
            

            

            
        }
    }
}
