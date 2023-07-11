using System.Drawing;

namespace FinalProject
{
    partial class EditUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBeat = new System.Windows.Forms.Button();
            this.tBlackNote = new System.Windows.Forms.TextBox();
            this.tDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBeatNumber = new System.Windows.Forms.TextBox();
            this.btnDeleteBeat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tPitch = new System.Windows.Forms.TextBox();
            this.cbNote = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBeatNumber2 = new System.Windows.Forms.TextBox();
            this.tNoteNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beats";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddBeat
            // 
            this.btnAddBeat.Location = new System.Drawing.Point(222, 95);
            this.btnAddBeat.Name = "btnAddBeat";
            this.btnAddBeat.Size = new System.Drawing.Size(100, 31);
            this.btnAddBeat.TabIndex = 1;
            this.btnAddBeat.Text = "Add Beat";
            this.btnAddBeat.UseVisualStyleBackColor = true;
            this.btnAddBeat.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBlackNote
            // 
            this.tBlackNote.Location = new System.Drawing.Point(152, 43);
            this.tBlackNote.Name = "tBlackNote";
            this.tBlackNote.Size = new System.Drawing.Size(170, 20);
            this.tBlackNote.TabIndex = 2;
            // 
            // tDuration
            // 
            this.tDuration.Location = new System.Drawing.Point(152, 69);
            this.tDuration.Name = "tDuration";
            this.tDuration.Size = new System.Drawing.Size(170, 20);
            this.tDuration.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Black Note";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beat Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Beat Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tBeatNumber
            // 
            this.tBeatNumber.Location = new System.Drawing.Point(152, 132);
            this.tBeatNumber.Name = "tBeatNumber";
            this.tBeatNumber.Size = new System.Drawing.Size(170, 20);
            this.tBeatNumber.TabIndex = 6;
            // 
            // btnDeleteBeat
            // 
            this.btnDeleteBeat.Location = new System.Drawing.Point(222, 158);
            this.btnDeleteBeat.Name = "btnDeleteBeat";
            this.btnDeleteBeat.Size = new System.Drawing.Size(100, 31);
            this.btnDeleteBeat.TabIndex = 8;
            this.btnDeleteBeat.Text = "Delete Beat";
            this.btnDeleteBeat.UseVisualStyleBackColor = true;
            this.btnDeleteBeat.Click += new System.EventHandler(this.btnDeleteBeat_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 20);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(12, 261);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(151, 23);
            this.btnAddNote.TabIndex = 10;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pitch";
            // 
            // tPitch
            // 
            this.tPitch.Location = new System.Drawing.Point(152, 301);
            this.tPitch.Name = "tPitch";
            this.tPitch.Size = new System.Drawing.Size(170, 20);
            this.tPitch.TabIndex = 11;
            // 
            // cbNote
            // 
            this.cbNote.FormattingEnabled = true;
            this.cbNote.Items.AddRange(new object[] {
            "Round Note",
            "Half Note",
            "Quarter Note",
            "Eigth Note",
            "Semiquaver Note",
            "Fuse",
            "Semifuse"});
            this.cbNote.Location = new System.Drawing.Point(152, 327);
            this.cbNote.Name = "cbNote";
            this.cbNote.Size = new System.Drawing.Size(170, 21);
            this.cbNote.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Beat Number";
            // 
            // tBeatNumber2
            // 
            this.tBeatNumber2.Location = new System.Drawing.Point(152, 381);
            this.tBeatNumber2.Name = "tBeatNumber2";
            this.tBeatNumber2.Size = new System.Drawing.Size(170, 20);
            this.tBeatNumber2.TabIndex = 19;
            // 
            // tNoteNumber
            // 
            this.tNoteNumber.Location = new System.Drawing.Point(152, 407);
            this.tNoteNumber.Name = "tNoteNumber";
            this.tNoteNumber.Size = new System.Drawing.Size(170, 20);
            this.tNoteNumber.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Note Number";
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(171, 261);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteNote.TabIndex = 22;
            this.btnDeleteNote.Text = "Delete Note";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(310, 31);
            this.label10.TabIndex = 23;
            this.label10.Text = "Notes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(152, 355);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(170, 20);
            this.tTime.TabIndex = 24;
            // 
            // EditUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 448);
            this.Controls.Add(this.tTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDeleteNote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tNoteNumber);
            this.Controls.Add(this.tBeatNumber2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tPitch);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteBeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBeatNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tDuration);
            this.Controls.Add(this.tBlackNote);
            this.Controls.Add(this.btnAddBeat);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(950, 25);
            this.Name = "EditUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Edit - CS MIDI Composer";
            this.Load += new System.EventHandler(this.EditUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBeat;
        private System.Windows.Forms.TextBox tBlackNote;
        private System.Windows.Forms.TextBox tDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBeatNumber;
        private System.Windows.Forms.Button btnDeleteBeat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tPitch;
        private System.Windows.Forms.ComboBox cbNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBeatNumber2;
        private System.Windows.Forms.TextBox tNoteNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tTime;
    }
}