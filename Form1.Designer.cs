
namespace RobotWebServices
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_localRegist = new System.Windows.Forms.Button();
            this.btn_mShipGet = new System.Windows.Forms.Button();
            this.btn_jogAxisModeSet = new System.Windows.Forms.Button();
            this.btn_J1Add = new System.Windows.Forms.Button();
            this.btn_J1Dec = new System.Windows.Forms.Button();
            this.btn_J2Add = new System.Windows.Forms.Button();
            this.btn_J2Dec = new System.Windows.Forms.Button();
            this.btn_J3Add = new System.Windows.Forms.Button();
            this.btn_J3Dec = new System.Windows.Forms.Button();
            this.btn_J4Add = new System.Windows.Forms.Button();
            this.btn_J4Dec = new System.Windows.Forms.Button();
            this.btn_J5Add = new System.Windows.Forms.Button();
            this.btn_J5Dec = new System.Windows.Forms.Button();
            this.btn_J6Add = new System.Windows.Forms.Button();
            this.btn_J6Dec = new System.Windows.Forms.Button();
            this.hsc_speed = new System.Windows.Forms.HScrollBar();
            this.lbl_showspeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_localRegist
            // 
            this.btn_localRegist.Location = new System.Drawing.Point(75, 43);
            this.btn_localRegist.Name = "btn_localRegist";
            this.btn_localRegist.Size = new System.Drawing.Size(162, 51);
            this.btn_localRegist.TabIndex = 0;
            this.btn_localRegist.Text = "注册本地用户";
            this.btn_localRegist.UseVisualStyleBackColor = true;
            this.btn_localRegist.Click += new System.EventHandler(this.btn_localRegist_Click);
            // 
            // btn_mShipGet
            // 
            this.btn_mShipGet.Location = new System.Drawing.Point(76, 122);
            this.btn_mShipGet.Name = "btn_mShipGet";
            this.btn_mShipGet.Size = new System.Drawing.Size(161, 50);
            this.btn_mShipGet.TabIndex = 1;
            this.btn_mShipGet.Text = "请求Motion权限";
            this.btn_mShipGet.UseVisualStyleBackColor = true;
            this.btn_mShipGet.Click += new System.EventHandler(this.btn_mShipGet_Click);
            // 
            // btn_jogAxisModeSet
            // 
            this.btn_jogAxisModeSet.Location = new System.Drawing.Point(76, 201);
            this.btn_jogAxisModeSet.Name = "btn_jogAxisModeSet";
            this.btn_jogAxisModeSet.Size = new System.Drawing.Size(162, 55);
            this.btn_jogAxisModeSet.TabIndex = 2;
            this.btn_jogAxisModeSet.Text = "设置单轴模式";
            this.btn_jogAxisModeSet.UseVisualStyleBackColor = true;
            this.btn_jogAxisModeSet.Click += new System.EventHandler(this.btn_jogAxisModeSet_Click);
            // 
            // btn_J1Add
            // 
            this.btn_J1Add.Location = new System.Drawing.Point(301, 43);
            this.btn_J1Add.Name = "btn_J1Add";
            this.btn_J1Add.Size = new System.Drawing.Size(121, 47);
            this.btn_J1Add.TabIndex = 3;
            this.btn_J1Add.Text = "J1+";
            this.btn_J1Add.UseVisualStyleBackColor = true;
            this.btn_J1Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J1Add_MouseDown);
            this.btn_J1Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J1Add_MouseUp);
            // 
            // btn_J1Dec
            // 
            this.btn_J1Dec.Location = new System.Drawing.Point(451, 43);
            this.btn_J1Dec.Name = "btn_J1Dec";
            this.btn_J1Dec.Size = new System.Drawing.Size(121, 47);
            this.btn_J1Dec.TabIndex = 3;
            this.btn_J1Dec.Text = "J1-";
            this.btn_J1Dec.UseVisualStyleBackColor = true;
            this.btn_J1Dec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J1Dec_MouseDown);
            this.btn_J1Dec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J1Dec_MouseUp);
            // 
            // btn_J2Add
            // 
            this.btn_J2Add.Location = new System.Drawing.Point(301, 109);
            this.btn_J2Add.Name = "btn_J2Add";
            this.btn_J2Add.Size = new System.Drawing.Size(121, 50);
            this.btn_J2Add.TabIndex = 4;
            this.btn_J2Add.Text = "J2+";
            this.btn_J2Add.UseVisualStyleBackColor = true;
            this.btn_J2Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J2Add_MouseDown);
            this.btn_J2Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J2Add_MouseUp);
            // 
            // btn_J2Dec
            // 
            this.btn_J2Dec.Location = new System.Drawing.Point(451, 109);
            this.btn_J2Dec.Name = "btn_J2Dec";
            this.btn_J2Dec.Size = new System.Drawing.Size(121, 50);
            this.btn_J2Dec.TabIndex = 4;
            this.btn_J2Dec.Text = "J2-";
            this.btn_J2Dec.UseVisualStyleBackColor = true;
            this.btn_J2Dec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J2Dec_MouseDown);
            this.btn_J2Dec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J2Dec_MouseUp);
            // 
            // btn_J3Add
            // 
            this.btn_J3Add.Location = new System.Drawing.Point(301, 176);
            this.btn_J3Add.Name = "btn_J3Add";
            this.btn_J3Add.Size = new System.Drawing.Size(121, 50);
            this.btn_J3Add.TabIndex = 4;
            this.btn_J3Add.Text = "J3+";
            this.btn_J3Add.UseVisualStyleBackColor = true;
            this.btn_J3Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J3Add_MouseDown);
            this.btn_J3Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J3Add_MouseUp);
            // 
            // btn_J3Dec
            // 
            this.btn_J3Dec.Location = new System.Drawing.Point(451, 176);
            this.btn_J3Dec.Name = "btn_J3Dec";
            this.btn_J3Dec.Size = new System.Drawing.Size(121, 50);
            this.btn_J3Dec.TabIndex = 4;
            this.btn_J3Dec.Text = "J3-";
            this.btn_J3Dec.UseVisualStyleBackColor = true;
            this.btn_J3Dec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J3Dec_MouseDown);
            this.btn_J3Dec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J3Dec_MouseUp);
            // 
            // btn_J4Add
            // 
            this.btn_J4Add.Location = new System.Drawing.Point(301, 244);
            this.btn_J4Add.Name = "btn_J4Add";
            this.btn_J4Add.Size = new System.Drawing.Size(121, 50);
            this.btn_J4Add.TabIndex = 4;
            this.btn_J4Add.Text = "J4+";
            this.btn_J4Add.UseVisualStyleBackColor = true;
            this.btn_J4Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J4Add_MouseDown);
            this.btn_J4Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J4Add_MouseUp);
            // 
            // btn_J4Dec
            // 
            this.btn_J4Dec.Location = new System.Drawing.Point(451, 244);
            this.btn_J4Dec.Name = "btn_J4Dec";
            this.btn_J4Dec.Size = new System.Drawing.Size(121, 50);
            this.btn_J4Dec.TabIndex = 4;
            this.btn_J4Dec.Text = "J4-";
            this.btn_J4Dec.UseVisualStyleBackColor = true;
            this.btn_J4Dec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J4Dec_MouseDown);
            this.btn_J4Dec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J4Dec_MouseUp);
            // 
            // btn_J5Add
            // 
            this.btn_J5Add.Location = new System.Drawing.Point(301, 312);
            this.btn_J5Add.Name = "btn_J5Add";
            this.btn_J5Add.Size = new System.Drawing.Size(121, 50);
            this.btn_J5Add.TabIndex = 4;
            this.btn_J5Add.Text = "J5+";
            this.btn_J5Add.UseVisualStyleBackColor = true;
            this.btn_J5Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J5Add_MouseDown);
            this.btn_J5Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_J5Add_MouseUp);
            // 
            // btn_J5Dec
            // 
            this.btn_J5Dec.Location = new System.Drawing.Point(451, 312);
            this.btn_J5Dec.Name = "btn_J5Dec";
            this.btn_J5Dec.Size = new System.Drawing.Size(121, 50);
            this.btn_J5Dec.TabIndex = 4;
            this.btn_J5Dec.Text = "J5-";
            this.btn_J5Dec.UseVisualStyleBackColor = true;
            this.btn_J5Dec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J5Dec_MouseDown);
            this.btn_J5Dec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J5Dec_MouseUp);
            // 
            // btn_J6Add
            // 
            this.btn_J6Add.Location = new System.Drawing.Point(301, 382);
            this.btn_J6Add.Name = "btn_J6Add";
            this.btn_J6Add.Size = new System.Drawing.Size(121, 50);
            this.btn_J6Add.TabIndex = 4;
            this.btn_J6Add.Text = "J6+";
            this.btn_J6Add.UseVisualStyleBackColor = true;
            this.btn_J6Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J6Add_MouseDown);
            this.btn_J6Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J6Add_MouseUp);
            // 
            // btn_J6Dec
            // 
            this.btn_J6Dec.Location = new System.Drawing.Point(451, 382);
            this.btn_J6Dec.Name = "btn_J6Dec";
            this.btn_J6Dec.Size = new System.Drawing.Size(121, 50);
            this.btn_J6Dec.TabIndex = 4;
            this.btn_J6Dec.Text = "J6-";
            this.btn_J6Dec.UseVisualStyleBackColor = true;
            this.btn_J6Dec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_J6Dec_MouseDown);
            this.btn_J6Dec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_J6Dec_MouseUp);
            // 
            // hsc_speed
            // 
            this.hsc_speed.Location = new System.Drawing.Point(76, 281);
            this.hsc_speed.Maximum = 2000;
            this.hsc_speed.Name = "hsc_speed";
            this.hsc_speed.Size = new System.Drawing.Size(162, 26);
            this.hsc_speed.TabIndex = 5;
            this.hsc_speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsc_speed_Scroll);
            // 
            // lbl_showspeed
            // 
            this.lbl_showspeed.AutoSize = true;
            this.lbl_showspeed.Location = new System.Drawing.Point(91, 326);
            this.lbl_showspeed.Name = "lbl_showspeed";
            this.lbl_showspeed.Size = new System.Drawing.Size(53, 18);
            this.lbl_showspeed.TabIndex = 6;
            this.lbl_showspeed.Text = "speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lbl_showspeed);
            this.Controls.Add(this.hsc_speed);
            this.Controls.Add(this.btn_J6Dec);
            this.Controls.Add(this.btn_J5Dec);
            this.Controls.Add(this.btn_J4Dec);
            this.Controls.Add(this.btn_J3Dec);
            this.Controls.Add(this.btn_J6Add);
            this.Controls.Add(this.btn_J5Add);
            this.Controls.Add(this.btn_J4Add);
            this.Controls.Add(this.btn_J3Add);
            this.Controls.Add(this.btn_J2Dec);
            this.Controls.Add(this.btn_J2Add);
            this.Controls.Add(this.btn_J1Dec);
            this.Controls.Add(this.btn_J1Add);
            this.Controls.Add(this.btn_jogAxisModeSet);
            this.Controls.Add(this.btn_mShipGet);
            this.Controls.Add(this.btn_localRegist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_localRegist;
        private System.Windows.Forms.Button btn_mShipGet;
        private System.Windows.Forms.Button btn_jogAxisModeSet;
        private System.Windows.Forms.Button btn_J1Add;
        private System.Windows.Forms.Button btn_J1Dec;
        private System.Windows.Forms.Button btn_J2Add;
        private System.Windows.Forms.Button btn_J2Dec;
        private System.Windows.Forms.Button btn_J3Add;
        private System.Windows.Forms.Button btn_J3Dec;
        private System.Windows.Forms.Button btn_J4Add;
        private System.Windows.Forms.Button btn_J4Dec;
        private System.Windows.Forms.Button btn_J5Add;
        private System.Windows.Forms.Button btn_J5Dec;
        private System.Windows.Forms.Button btn_J6Add;
        private System.Windows.Forms.Button btn_J6Dec;
        private System.Windows.Forms.HScrollBar hsc_speed;
        private System.Windows.Forms.Label lbl_showspeed;
    }
}

