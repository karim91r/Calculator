namespace WinFormsApp8
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
   

  
        partial class Form1
        {
            /// <summary>
            ///  Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button0 = new Button();
            Button1 = new Button();
            Button2 = new Button();
            Button3 = new Button();
            Button4 = new Button();
            Button5 = new Button();
            Button6 = new Button();
            Button7 = new Button();
            Button8 = new Button();
            Button9 = new Button();
            ButtonSum = new Button();
            ButtonDiv = new Button();
            ButtonMult = new Button();
            ButtonSub = new Button();
            ButtonDot = new Button();
            ButtonPre = new Button();
            ButtonCalc = new Button();
            ButtonClear = new Button();
            Screen = new TextBox();
            SuspendLayout();
            // 
            // Button0
            // 
            Button0.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button0.ForeColor = Color.White;
            Button0.Location = new Point(10, 510);
            Button0.Margin = new Padding(2);
            Button0.Name = "Button0";
            Button0.Size = new Size(80, 80);
            Button0.TabIndex = 0;
            Button0.Text = "0";
            Button0.Click += Button0_Click;
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(10, 400);
            Button1.Margin = new Padding(2);
            Button1.Name = "Button1";
            Button1.Size = new Size(80, 80);
            Button1.TabIndex = 1;
            Button1.Text = "1";
            Button1.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button2.ForeColor = Color.White;
            Button2.Location = new Point(120, 400);
            Button2.Margin = new Padding(2);
            Button2.Name = "Button2";
            Button2.Size = new Size(80, 80);
            Button2.TabIndex = 2;
            Button2.Text = "2";
            Button2.Click += Button2_Click;
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button3.ForeColor = Color.White;
            Button3.Location = new Point(230, 400);
            Button3.Margin = new Padding(2);
            Button3.Name = "Button3";
            Button3.Size = new Size(80, 80);
            Button3.TabIndex = 3;
            Button3.Text = "3";
            Button3.Click += Button3_Click;
            // 
            // Button4
            // 
            Button4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button4.ForeColor = Color.White;
            Button4.Location = new Point(10, 290);
            Button4.Margin = new Padding(2);
            Button4.Name = "Button4";
            Button4.Size = new Size(80, 80);
            Button4.TabIndex = 4;
            Button4.Text = "4";
            Button4.Click += Button4_Click;
            // 
            // Button5
            // 
            Button5.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button5.ForeColor = Color.White;
            Button5.Location = new Point(120, 290);
            Button5.Margin = new Padding(2);
            Button5.Name = "Button5";
            Button5.Size = new Size(80, 80);
            Button5.TabIndex = 5;
            Button5.Text = "5";
            Button5.Click += Button5_Click;
            // 
            // Button6
            // 
            Button6.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button6.ForeColor = Color.White;
            Button6.Location = new Point(230, 290);
            Button6.Margin = new Padding(2);
            Button6.Name = "Button6";
            Button6.Size = new Size(80, 80);
            Button6.TabIndex = 6;
            Button6.Text = "6";
            Button6.Click += Button6_Click;
            // 
            // Button7
            // 
            Button7.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button7.ForeColor = Color.White;
            Button7.Location = new Point(10, 180);
            Button7.Margin = new Padding(2);
            Button7.Name = "Button7";
            Button7.Size = new Size(80, 80);
            Button7.TabIndex = 7;
            Button7.Text = "7";
            Button7.Click += Button7_Click;
            // 
            // Button8
            // 
            Button8.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button8.ForeColor = Color.White;
            Button8.Location = new Point(120, 180);
            Button8.Margin = new Padding(2);
            Button8.Name = "Button8";
            Button8.Size = new Size(80, 80);
            Button8.TabIndex = 8;
            Button8.Text = "8";
            Button8.Click += Button8_Click;
            // 
            // Button9
            // 
            Button9.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button9.ForeColor = Color.White;
            Button9.Location = new Point(230, 180);
            Button9.Margin = new Padding(2);
            Button9.Name = "Button9";
            Button9.Size = new Size(80, 80);
            Button9.TabIndex = 9;
            Button9.Text = "9";
            Button9.Click += Button9_Click;
            // 
            // ButtonSum
            // 
            ButtonSum.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSum.ForeColor = Color.OrangeRed;
            ButtonSum.Location = new Point(340, 400);
            ButtonSum.Margin = new Padding(2);
            ButtonSum.Name = "ButtonSum";
            ButtonSum.Size = new Size(80, 80);
            ButtonSum.TabIndex = 10;
            ButtonSum.Text = "+";
            ButtonSum.Click += ButtonSum_Click;
            // 
            // ButtonDiv
            // 
            ButtonDiv.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDiv.ForeColor = Color.OrangeRed;
            ButtonDiv.Location = new Point(340, 290);
            ButtonDiv.Margin = new Padding(2);
            ButtonDiv.Name = "ButtonDiv";
            ButtonDiv.Size = new Size(80, 80);
            ButtonDiv.TabIndex = 11;
            ButtonDiv.Text = "/";
            ButtonDiv.Click += ButtonDiv_Click;
            // 
            // ButtonMult
            // 
            ButtonMult.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMult.ForeColor = Color.OrangeRed;
            ButtonMult.Location = new Point(230, 510);
            ButtonMult.Margin = new Padding(2);
            ButtonMult.Name = "ButtonMult";
            ButtonMult.Size = new Size(80, 80);
            ButtonMult.TabIndex = 12;
            ButtonMult.Text = "x";
            ButtonMult.Click += ButtonMult_Click;
            // 
            // ButtonSub
            // 
            ButtonSub.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSub.ForeColor = Color.OrangeRed;
            ButtonSub.Location = new Point(340, 510);
            ButtonSub.Margin = new Padding(2);
            ButtonSub.Name = "ButtonSub";
            ButtonSub.Size = new Size(80, 80);
            ButtonSub.TabIndex = 13;
            ButtonSub.Text = "-";
            ButtonSub.Click += ButtonSub_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDot.ForeColor = Color.OrangeRed;
            ButtonDot.Location = new Point(120, 510);
            ButtonDot.Margin = new Padding(2);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(80, 80);
            ButtonDot.TabIndex = 14;
            ButtonDot.Text = ".";
            ButtonDot.Click += ButtonDot_Click;
            // 
            // ButtonPre
            // 
            ButtonPre.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPre.ForeColor = Color.OrangeRed;
            ButtonPre.Location = new Point(340, 180);
            ButtonPre.Margin = new Padding(2);
            ButtonPre.Name = "ButtonPre";
            ButtonPre.Size = new Size(80, 80);
            ButtonPre.TabIndex = 15;
            ButtonPre.Text = "%";
            ButtonPre.Click += ButtonPre_Click;
            // 
            // ButtonCalc
            // 
            ButtonCalc.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCalc.ForeColor = Color.OrangeRed;
            ButtonCalc.Location = new Point(230, 610);
            ButtonCalc.Margin = new Padding(2);
            ButtonCalc.Name = "ButtonCalc";
            ButtonCalc.Size = new Size(190, 80);
            ButtonCalc.TabIndex = 15;
            ButtonCalc.Text = "=";
            ButtonCalc.Click += ButtonCalc_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.ForeColor = Color.OrangeRed;
            ButtonClear.Location = new Point(10, 610);
            ButtonClear.Margin = new Padding(2);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(190, 80);
            ButtonClear.TabIndex = 15;
            ButtonClear.Text = "Clear";
            ButtonClear.Click += ButtonClear_Click;
            // 
            // Screen
            // 
            Screen.BackColor = Color.White;
            Screen.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Screen.Location = new Point(10, 20);
            Screen.Margin = new Padding(2);
            Screen.Multiline = true;
            Screen.Name = "Screen";
            Screen.Size = new Size(410, 120);
            Screen.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(516, 750);
            Controls.Add(Button0);
            Controls.Add(Button1);
            Controls.Add(Button2);
            Controls.Add(Button3);
            Controls.Add(Button4);
            Controls.Add(Button5);
            Controls.Add(Button6);
            Controls.Add(Button7);
            Controls.Add(Button8);
            Controls.Add(Button9);
            Controls.Add(ButtonSum);
            Controls.Add(ButtonSub);
            Controls.Add(ButtonMult);
            Controls.Add(ButtonDiv);
            Controls.Add(ButtonDot);
            Controls.Add(ButtonPre);
            Controls.Add(ButtonCalc);
            Controls.Add(ButtonClear);
            Controls.Add(Screen);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Calc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button Button1;
            private Button Button2;
            private Button Button3;
            private Button Button4;
            private Button Button5;
            private Button Button6;
            private Button Button7;
            private Button Button8;
            private Button Button9;
            private Button Button0;
            private Button ButtonMult;
            private Button ButtonDiv;
            private Button ButtonSum;
            private Button ButtonSub;
            private Button ButtonDot;
            private Button ButtonCalc;
            private Button ButtonClear;
            private TextBox Screen;
            private Button ButtonPre;



            #endregion
        }
    }

