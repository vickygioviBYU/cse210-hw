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
    public partial class ScoreUI : Form, Observer
    {
        private Facade _fc;
        public ScoreUI(Facade fc)
        {
            InitializeComponent();
            _fc = fc;
            _fc.Agregar(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void Actualizar(Observable origen, Object evento)
        {
            if (origen == _fc)
            {
                if (evento.Equals("Update score"))
                {
                    LoadScore();
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            SolidBrush myBrushBlue = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            Pen blackPen = new Pen(Color.Black, 1);

            int left = 0;
            int top = 0;

            int middleC = 60;

            for(int i = 0; i < 88; i++) {

                if (i % 12 == 0)
                {
                    gra.FillRectangle(myBrushBlue, new Rectangle(left, top, 39, 7));
                } else
                {
                    gra.FillRectangle(myBrush, new Rectangle(left, top, 39, 7));
                }
                gra.DrawRectangle(blackPen, left, top, 39, 7);
                top += 7;
            }     
        }

        private void LoadScore()
        {
            Graphics gra = this.panel3.CreateGraphics();
            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Cyan);
            Pen blackPen = new Pen(Color.Black, 1);

            gra.Clear(Color.White);

            try
            {
                int beatSelected = int.Parse(tBeatSelected.Text);

                if (beatSelected - 1 < _fc.QuantityBeats() && beatSelected > 0)
                {
                    List<Note> notes = _fc.GetNotes(beatSelected);

                    int posFirstKey = 609;

                    if (notes != null)
                    {
                        foreach (Note note in notes)
                        {
                            if (note.GetPitch() >= 21 && note.GetPitch() <= 108)
                            {
                                int notePitch = note.GetPitch();
                                int firstKey = 21;
                                int diff = notePitch - firstKey;

                                int deltaTime = note.GetDeltaTime();
                                int typeNote = note.GetTypeNote();
                                int widthPanel = 854;
                                int beatDuration = _fc.GetDuration(beatSelected);

                                double initSquare = (double)widthPanel / (double)beatDuration * (double)deltaTime;
                                double endSquare = (double)widthPanel / (double)beatDuration * (double)typeNote;
                                int initInt = (int)initSquare;
                                int endInt = (int)endSquare;

                                gra.FillRectangle(myBrush, initInt, posFirstKey - (diff * 7), endInt, 7);
                                gra.DrawRectangle(blackPen, initInt, posFirstKey - (diff * 7), endInt, 7);
                            }

                        }
                        //int top = 0;
                        //foreach (Note note in notes)
                        //{
                        //    gra.FillRectangle(myBrush, 0, top, 39, 7);
                        //    gra.DrawRectangle(blackPen, 0, top, 39, 7);
                        //    top += 7;
                        //}
                    }
                }
            } catch (Exception ex)
            {

            }

            

            

            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            LoadScore();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadScore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fc.IterateNotes();
        }
    }
}
